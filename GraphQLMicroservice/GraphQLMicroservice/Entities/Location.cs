using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Location
    {
        public string Street_number { get; set; }
        public string Street_name { get; set; }
        public string Nunicipality_subdivision { get; set; }
        public string Nunicipality { get; set; }
        public string Nountry_secondary_subdivision { get; set; }
        public string Nountry_tertiary_subdivision { get; set; }
        public string Country_subdivision { get; set; }
        public string Postal_code { get; set; }
        public string Country_code { get; set; }
        public string Country { get; set; }
        public string Country_codeISO3 { get; set; }
        public string Freeform_address { get; set; }
        public string Country_subdivision_name { get; set; }
    }
}
