using GraphQLConsumingClient.Helpers;
using GraphQLMicroservice.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GraphQLConsumingClient.Controllers
{
    public class GraphQLClient
    {
        
        public const string GraphqlAddress = "https://localhost:44398/graphql/";

        private readonly HttpClient _httpClient;

        public GraphQLClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Response<List<Material>>> GetMaterialsAsync()
        {
            var response = await _httpClient.GetAsync(
                @"?query={
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
                            }");

            var stringResult = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Response<List<Material>>>(stringResult);
        }
    }
}
