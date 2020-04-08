using GraphQL;
using GraphQL.Types;
using GraphQLSimpleTalk.Queries;
using GraphQLSimpleTalk.Queries.EC3Trials;
using GraphQLSimpleTalk.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Controllers
{
    [Route(Startup.GraphQLPath)]
    public class GraphQlController : Controller
    {
        /*
        readonly BlogService blogService;
        public GraphQlController(BlogService blogService)
        {
            this.blogService = blogService;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            var schema = new Schema { Query = new AuthorQuery(blogService) };
            var result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = schema;
                x.Query = query.Query;
                x.Inputs = query.Variables;
            });
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }*/
        private readonly IDocumentExecuter _documentExecuter;
        private readonly ISchema _schema;
        //readonly EC3Service ec3Service;
        public GraphQlController(ISchema schema, IDocumentExecuter documentExecuter)
        {
            _schema = schema;
            _documentExecuter = documentExecuter;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GraphQlQuery query)
        {
            //var schema = new Schema { Query = new MaterialQuery(ec3Service) };
            var result = await new DocumentExecuter().ExecuteAsync(x =>
            {
                x.Schema = _schema;
                x.Query = query.Query;
                x.Inputs = query.Variables.ToInputs();
            });
            if (result.Errors?.Count > 0)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
