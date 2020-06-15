using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class PlantType : ObjectGraphType<Plant>
    {
        public PlantType()
        {
            Field(x => x.Id);
            Field(x => x.Created_on);
            Field(x => x.Updated_on);
            Field<OwnerType>("owner");
            Field(x => x.Address);
            Field(x => x.Latitude);
            Field(x => x.Longitude);
            Field<PlantLocationType>("location");
            Field(x => x.Address_line);
            Field(x => x.Admin_district);
            Field(x => x.Admin_district2);
            Field(x => x.Locality);
            Field(x => x.Postal_code);
            Field(x => x.Country);
            Field(x => x.Name);
            Field<ListGraphType<StringGraphType>>("alt_names");
            Field<OwnedByType>("owned_by");
            Field(x => x.Gwp_contact);
            Field(x => x.Contact_website);
            Field(x => x.Currency);
            Field(x => x.Units);
            Field(x => x.Origin_code);
            Field(x => x.Notes);
            Field(x => x.Distance);
            Field(x => x.Carbon_intensity);
            Field<ListGraphType<StringGraphType>>("categories");
        }
    }
}
