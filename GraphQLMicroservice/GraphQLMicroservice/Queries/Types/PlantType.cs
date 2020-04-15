using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class PlantType : ObjectGraphType<Plant>
    {
        public PlantType()
        {
            Field(x => x.Id);
            Field(x => x.CreatedOn);
            Field(x => x.UpdatedOn);
            Field<OwnerType>("owner");
            Field(x => x.Address);
            Field(x => x.Latitude);
            Field(x => x.Longitude);
            Field<LocationType>("location");
            Field(x => x.AddressLine);
            Field(x => x.AdminDistrict);
            Field(x => x.AdminDistrict2);
            Field(x => x.Locality);
            Field(x => x.PostalCode);
            Field(x => x.Country);
            Field(x => x.Name);
            Field<ListGraphType<StringGraphType>>("alt_names");
            Field<OwnedByType>("owned_by");
            Field(x => x.GwpContact);
            Field(x => x.ContactWebsite);
            Field(x => x.Currency);
            Field(x => x.Units);
            Field(x => x.OriginCode);
            Field(x => x.Notes);
            Field(x => x.Distance);
            Field(x => x.CarbonIntensity);
            Field<ListGraphType<StringGraphType>>("categories");
        }
    }
}
