﻿using GraphQLMicroservice.Entities;
using GraphQLMicroservice.LoginInformation;
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

namespace GraphQLMicroservice.Services
{
    public class EC3Service
    {
        private const string BASE_URL = "https://etl-api.cqd.io/api";

        public List<Material> GetAllMaterials()
        {
            string responseString = string.Empty;
            LoginCredentials deserializedLoginCredentials = JsonConvert.DeserializeObject<LoginCredentials>(Login());
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(BASE_URL + "/materials");
            request.PreAuthenticate = true;
            request.Headers.Add("Authorization", "Bearer " + deserializedLoginCredentials.key);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode);
                }

                //process the response stream
                using (Stream streamObj = response.GetResponseStream())
                {
                    if (streamObj != null)
                    {
                        using (StreamReader reader = new StreamReader(streamObj))
                        {
                            responseString = reader.ReadToEnd();
                        }
                    }
                }
            }

            DebugOutput(responseString);

            List<Material> materialList = JsonConvert.DeserializeObject<List<Material>>(responseString);

            DebugOutput("Amount of materials : " + materialList.Count);
            
            return materialList;
        }

        //returns the login information, including a key that needs to be passed around in order to use the API
        private string Login()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(BASE_URL + "/rest-auth/login");
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
                DebugOutput(result);
            }
            return result;
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

    }
}
