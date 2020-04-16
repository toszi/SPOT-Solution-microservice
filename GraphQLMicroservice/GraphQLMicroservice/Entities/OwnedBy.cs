using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class OwnedBy
    {
        public string Id { get; set; }
        public string Created_on { get; set; }
        public string Updated_on { get; set; }
        public Owner Owner { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location Location { get; set; }
        public string Address_line { get; set; }
        public string Admin_district { get; set; }
        public string Admin_district2 { get; set; }
        public string Locality { get; set; }
        public string Postal_code { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Legal_name { get; set; }
        public List<string> Alt_names { get; set; }
        public string Jurisdiction { get; set; }
        public bool Primary_activity_owner { get; set; }
        public bool Primary_activity_builder { get; set; }
        public bool Primary_activity_design { get; set; }
        public bool Primary_activity_manufacturer { get; set; }
        public bool Primary_activity_operator { get; set; }
        public bool Primary_activity_verifier { get; set; }
        public bool Primary_activity_industry_association { get; set; }
        public bool Primary_activity_other { get; set; }
        public bool Primary_activity_forest_practices_certification { get; set; }
        public bool Primary_activity_digitization_qa { get; set; }
        public bool Primary_activity_sustainability_consulting { get; set; }
        public string Tax_id { get; set; }
        public string Website { get; set; }
        public string Transparency_catalog_link { get; set; }
        public string Email { get; set; }
        public string Org_type { get; set; }
        public string Currency { get; set; }
        public bool Enterprise { get; set; }
        public string Parent { get; set; }
        public string Gwp_contact { get; set; }
        public string User_group_employees { get; set; }
        public string Primary_sustainability_contact { get; set; }
    }
}
