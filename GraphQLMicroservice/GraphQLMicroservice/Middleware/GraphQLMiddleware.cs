﻿using GraphQL;
using GraphQL.Http;
using GraphQL.Instrumentation;
using GraphQL.Server.Transports.AspNetCore.Common;
using GraphQL.Types;
using GraphQL.Validation;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Middleware
{
    public class GraphQLMiddleware
    {
        readonly static Lazy<JsonSerializer> _serializerHolder = new Lazy<JsonSerializer>(() => new JsonSerializer());

        readonly RequestDelegate _next;
        readonly GraphQLSettings _settings;
        readonly IDocumentExecuter _executer;
        readonly IDocumentWriter _writer;

        public GraphQLMiddleware(RequestDelegate next, GraphQLSettings settings, IDocumentExecuter executer, IDocumentWriter writer) =>
            (_next, _settings, _executer, _writer) = (next, settings, executer, writer);

        static JsonSerializer Serializer => _serializerHolder.Value;

        public Task Invoke(HttpContext context, ISchema schema)
        {
            var (isGraphQLRequest, request) = IsGraphQLRequest(context);

            if (isGraphQLRequest && request is GraphQLRequest)
                return ExecuteAsync(context, schema, request);

            return _next(context);
        }

        static T Deserialize<T>(Stream stream)
        {
            using (var streamReader = new StreamReader(stream)) ;
            using (var jsonTextReader = new JsonTextReader(streamReader)) ;

            return Serializer.Deserialize<T>(jsonTextReader);
        }

        (bool isGraphQLRequest, GraphQLRequest? request) IsGraphQLRequest(in HttpContext context)
        {
            try
            {
                return (context.Request.Path.StartsWithSegments(_settings.Path) && context.Request.Method.Equals("POST", StringComparison.OrdinalIgnoreCase),
                            Deserialize<GraphQLRequest>(context.Request.Body));
            }
            catch
            {
                return (false, null);
            }
        }

        async Task ExecuteAsync(HttpContext context, ISchema schema, GraphQLRequest request)
        {
            var result = await _executer.ExecuteAsync(options =>
            {
                options.Schema = schema;
                options.Query = request.Query;
                options.OperationName = request.OperationName ?? string.Empty;
                options.Inputs = request.Variables?.ToInputs();
                options.UserContext = _settings.BuildUserContext.Invoke(context);
                options.ValidationRules = DocumentValidator.CoreRules.Concat(new[] { new InputValidationRule() });
                options.EnableMetrics = _settings.EnableMetrics;

                if (_settings.EnableMetrics)
                    options.FieldMiddleware.Use<InstrumentFieldsMiddleware>();
            });

            await WriteResponseAsync(context, result).ConfigureAwait(false);
        }

        Task WriteResponseAsync(in HttpContext context, in ExecutionResult result)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = result.Errors?.Any() is true ? (int)HttpStatusCode.BadRequest : (int)HttpStatusCode.OK;

            return _writer.WriteAsync(context.Response.Body, result);
        }
    }
}
