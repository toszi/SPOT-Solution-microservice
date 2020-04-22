using System;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using GraphQLMicroservice.Entities;
using Microsoft.AspNetCore.Mvc;
using GraphQL;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;

namespace GraphQLConsumingClient.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<List<Material>> Get()
        {
            /*
            var graphQLClient = new GraphQLHttpClient("http://localhost:44398/graphql", new NewtonsoftJsonSerializer());
            
            var request = new GraphQLRequest
            {
                Query = @"?query={
                              materials{
                                id
                                name
                                description
                                gwp_z
                                concrete_scm_details{
                                  fly_ash
                                }
                                pct80_gwp_per_category_declared_unit
                                manufacturer{
                                  name
                                  alt_names
                                  location{
                                    country
                                    postalCode
                                  }
                                }
                                plant{
                                  name
                                  alt_names
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
            var response = await graphQLClient.SendQueryAsync<List<Material>>(request);

            Console.WriteLine(JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true }));
            if (response.Errors != null && response.Errors.Any())
            {
                throw new ApplicationException(response.Errors[0].Message);
            }


            return JsonSerializer.Serialize(response, new JsonSerializerOptions { WriteIndented = true });*/
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:44398/graphql")
            };

            var queryObject = new
            {
                query = @"query { 
                viewer { 
                login
                }
            }",
                variables = new { }
            };

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                Content = new StringContent(JsonConvert.SerializeObject(queryObject), Encoding.UTF8, "application/json")
            };

            dynamic responseObj;

            using (var response = await httpClient.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();

                var responseString = await response.Content.ReadAsStringAsync();
                responseObj = JsonConvert.DeserializeObject<dynamic>(responseString);
            }

            Console.WriteLine(responseObj);

            return responseObj;
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
