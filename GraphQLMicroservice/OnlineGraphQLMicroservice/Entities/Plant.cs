using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGraphQLMicroservice.Entities
{
    public class Plant
    {
        public string Id { get; set; }
        public string Created_on { get; set; }
        public string Updated_on { get; set; }
        public Owner Owner { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public PlantLocation Location { get; set; }
        public string Address_line { get; set; }
        public string Admin_district { get; set; }
        public string Admin_district2 { get; set; }
        public string Locality { get; set; }
        public string Postal_code { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public List<string> Alt_names { get; set; }
        public OwnedBy Owned_by { get; set; }
        public string Gwp_contact { get; set; }
        public string Contact_website { get; set; }
        public string Currency { get; set; }
        public string Units { get; set; }
        public string Origin_code { get; set; }
        public string Notes { get; set; }
        public string Distance { get; set; }
        public string Carbon_intensity { get; set; }
        public List<Category> Categories { get; set; }
        public int Total_epds { get; set; }
    }
}
