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
            Field(x => x.Street_number);
            Field(x => x.Street_name);
            Field(x => x.Nunicipality_subdivision);
            Field(x => x.Nunicipality);
            Field(x => x.Nountry_secondary_subdivision);
            Field(x => x.Nountry_tertiary_subdivision);
            Field(x => x.Country_subdivision);
            Field(x => x.Postal_code);
            Field(x => x.Country_code);
            Field(x => x.Country);
            Field(x => x.Country_codeISO3);
            Field(x => x.Freeform_address);
            Field(x => x.Country_subdivision_name);
        }
    }
}
