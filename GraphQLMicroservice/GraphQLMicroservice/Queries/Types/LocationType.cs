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
            Field(x => x.MunicipalitySubdivision);
            Field(x => x.Municipality);
            Field(x => x.CountrySecondarySubdivision);
            Field(x => x.CountryTertiarySubdivision);
            Field(x => x.CountrySubdivision);
            Field(x => x.PostalCode);
            Field(x => x.ExtendedPostalCode);
            Field(x => x.CountryCode);
            Field(x => x.Country);
            Field(x => x.CountryCodeISO3);
            Field(x => x.FreeformAddress);
            Field(x => x.LocalName);
            Field(x => x.CountrySubdivisionName);
        }
    }
}
