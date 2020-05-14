using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using GraphQLMicroservice.Entities;
using Microsoft.AspNetCore.Mvc;
using GraphQL.Client.Serializer.Newtonsoft;
using System.Text.Json;
using GraphQL.Client.Http;
using GraphQL.Client.Abstractions;
using System.Net.Http;
using GraphQLConsumingClient.Helpers;

namespace GraphQLConsumingClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            /*
            GraphQLClient client = new GraphQLClient(new HttpClient());
            var response = await client.GetMaterialsAsync();
            response.OnErrorThrowException();
            var reservations = response.Data;
            */
            
            var graphQLClient = new GraphQLHttpClient("http://localhost:44398/graphql", new NewtonsoftJsonSerializer());
            
            var request = new GraphQLHttpRequest
            {
                Query = @"query={
                              materials{
                                id
                                name
                                concrete_scm_details{
                                  fly_ash
                                }
                                pct80_gwp_per_category_declared_unit
                                manufacturer{
                                  name
                                  location{
                                    country
                                  }
                                }
                                plant{
                                  name
                                  location{
                                    localName
                                  }
                                  owned_by{
                                    name
                                    location{
                                      country
                                    }
                                  }
                                }
                              }
                            }
                         "
            };

            var response = await graphQLClient.SendQueryAsync(request, () => new { materials = new List<Material>() });
            List<Material> materials = response.Data.materials;

            for (int i = 0; i < materials.Count; i++)
            {
                DebugOutput("Amount of materials: " + i);
            }
            
            if (response.Errors != null && response.Errors.Any())
            {
                throw new ApplicationException(response.Errors[0].Message);
            }

            return JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });
        }

        //print in the debug window
        private void DebugOutput(string debugString)
        {
            try
            {
                System.Diagnostics.Debug.Write(debugString + Environment.NewLine);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
