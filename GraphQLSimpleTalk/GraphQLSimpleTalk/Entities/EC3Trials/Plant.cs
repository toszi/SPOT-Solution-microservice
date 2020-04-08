using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Entities.EC3Trials
{
    public class Plant
    {
        public string id { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
        public object owner { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Location2 location { get; set; }
        public string address_line { get; set; }
        public string admin_district { get; set; }
        public string admin_district2 { get; set; }
        public string locality { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public object alt_names { get; set; }
        public OwnedBy owned_by { get; set; }
        public object gwp_contact { get; set; }
        public object contact_website { get; set; }
        public object currency { get; set; }
        public object units { get; set; }
        public object origin_code { get; set; }
        public object notes { get; set; }
        public object distance { get; set; }
        public string carbon_intensity { get; set; }
        public object categories { get; set; }
        public int total_epds { get; set; }
    }
}
