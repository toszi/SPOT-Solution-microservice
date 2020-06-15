using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGraphQLMicroservice.Services
{
    public class LoginCredentials
    {
        public string key { get; set; }
        public string last_login { get; set; }
    }
}
