﻿using GraphiQl;
using GraphQL;
using GraphQL.Http;
using GraphQL.Server;
using GraphQL.Types;
using GraphQLMicroservice.Queries;
using GraphQLMicroservice.Queries.Types;
using GraphQLMicroservice.Schemas;
using GraphQLMicroservice.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GraphQLMicroservice
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddHttpContextAccessor();
            services.AddSingleton<EC3Service>();
            services.AddSingleton<MaterialQuery>();
            services.AddSingleton<MaterialType>();
            services.AddSingleton<OwnerType>();
            services.AddSingleton<ConcreteScmDetailsType>();
            services.AddSingleton<CategoryType>();
            services.AddSingleton<PlantLocationType>();
            services.AddSingleton<ManufacturerLocationType>();
            services.AddSingleton<OwnedByLocationType>();
            services.AddSingleton<ManufacturerType>();
            services.AddSingleton<OwnedByType>();
            services.AddSingleton<PlantType>();
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            var sp = services.BuildServiceProvider();
            services.AddSingleton<ISchema>(new MaterialSchema(new FuncDependencyResolver(type => sp.GetService(type))));

            /*
            services.AddGraphQL(x =>
            {
                x.ExposeExceptions = true; //set true only in development mode. make it switchable.
            }).AddGraphTypes(ServiceLifetime.Scoped);*/
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public const string graphqlPath = "/graphql";
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            /*
            app.UseGraphQL<MaterialSchema>();
            */
            app.UseGraphiQl();
            app.UseMvc();
        }
    }
}
