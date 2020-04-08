using GraphQLSimpleTalk.Entities.EC3Trials;
using GraphQLSimpleTalk.Login;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Services
{
    public class EC3Service
    {
        private const string baseURL = "https://etl-api.cqd.io/api";

        public string GetAllMaterials()
        {
            string responseString = string.Empty;
            LoginCredentials deserializedLoginCredentials = JsonConvert.DeserializeObject<LoginCredentials>(login());
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseURL+ "/materials");
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer " + deserializedLoginCredentials.key);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if(response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }
                
                //process the response stream
                using(Stream streamObj = response.GetResponseStream())
                {
                    if (streamObj != null)
                    {
                        using(StreamReader reader = new StreamReader(streamObj))
                        {
                            responseString = reader.ReadToEnd();
                        }
                    }
                }
            }

            debugOutput(responseString);

            return responseString;
        }

        private void debugOutput(string debugString)
        {
            try
            {
                System.Diagnostics.Debug.Write(debugString + Environment.NewLine);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }

        private string login()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(baseURL + "/rest-auth/login");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string loginInformation = "{\"username\":\"toszi18@gmail.com\"," +
                    "\"password\":\"Spiderman14\"}";

                streamWriter.Write(loginInformation);
            }

            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            string result = string.Empty;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
                debugOutput(result);
            }
            return result;
        }

    }
}
