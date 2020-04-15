using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Plant
    {
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public Owner Owner { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location Location { get; set; }
        public string AddressLine { get; set; }
        public string AdminDistrict { get; set; }
        public string AdminDistrict2 { get; set; }
        public string Locality { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Name { get; set; }
        public List<string> AltNames { get; set; }
        public OwnedBy OwnedBy { get; set; }
        public string GwpContact { get; set; }
        public string ContactWebsite { get; set; }
        public string Currency { get; set; }
        public string Units { get; set; }
        public string OriginCode { get; set; }
        public string Notes { get; set; }
        public string Distance { get; set; }
        public string CarbonIntensity { get; set; }
        public List<Category> Categories { get; set; }
        public int TotalEpds { get; set; }
    }
}
