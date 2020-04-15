using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class LocationType : ObjectGraphType<Location>
    {
        public LocationType()
        {
            Field(x => x.StreetNumber);
            Field(x => x.StreetName);
            Field(x => x.NunicipalitySubdivision);
            Field(x => x.Nunicipality);
            Field(x => x.NountrySecondarySubdivision);
            Field(x => x.NountryTertiarySubdivision);
            Field(x => x.CountrySubdivision);
            Field(x => x.PostalCode);
            Field(x => x.CountryCode);
            Field(x => x.Country);
            Field(x => x.CountryCodeISO3);
            Field(x => x.FreeformAddress);
            Field(x => x.CountrySubdivisionName);
        }
    }
}
