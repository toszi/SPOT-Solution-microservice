using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Entities.EC3Trials
{
    public class OwnedBy
    {
        public string id { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
        public object owner { get; set; }
        public string address { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Location location { get; set; }
        public string address_line { get; set; }
        public string admin_district { get; set; }
        public string admin_district2 { get; set; }
        public string locality { get; set; }
        public string postal_code { get; set; }
        public string country { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string legal_name { get; set; }
        public List<string> alt_names { get; set; }
        public object jurisdiction { get; set; }
        public bool primary_activity_owner { get; set; }
        public bool primary_activity_builder { get; set; }
        public bool primary_activity_design { get; set; }
        public bool primary_activity_manufacturer { get; set; }
        public bool primary_activity_operator { get; set; }
        public bool primary_activity_verifier { get; set; }
        public bool primary_activity_industry_association { get; set; }
        public bool primary_activity_other { get; set; }
        public bool primary_activity_forest_practices_certification { get; set; }
        public bool primary_activity_digitization_qa { get; set; }
        public bool primary_activity_sustainability_consulting { get; set; }
        public object tax_id { get; set; }
        public string website { get; set; }
        public string transparency_catalog_link { get; set; }
        public object email { get; set; }
        public string org_type { get; set; }
        public object currency { get; set; }
        public bool enterprise { get; set; }
        public object parent { get; set; }
        public object gwp_contact { get; set; }
        public object user_group_employees { get; set; }
        public object primary_sustainability_contact { get; set; }
    }
}
