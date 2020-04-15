using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Location
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string NunicipalitySubdivision { get; set; }
        public string Nunicipality { get; set; }
        public string NountrySecondarySubdivision { get; set; }
        public string NountryTertiarySubdivision { get; set; }
        public string CountrySubdivision { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string Country { get; set; }
        public string CountryCodeISO3 { get; set; }
        public string FreeformAddress { get; set; }
        public string CountrySubdivisionName { get; set; }
    }
}
