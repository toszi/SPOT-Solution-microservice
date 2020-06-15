using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class OwnedByType : ObjectGraphType<OwnedBy>
    {
        public OwnedByType()
        {
            Field(x => x.Id);
            Field(x => x.Created_on);
            Field(x => x.Updated_on);
            Field<OwnerType>("owner");
            Field(x => x.Address);
            Field(x => x.Latitude);
            Field(x => x.Longitude);
            Field<OwnedByLocationType>("location");
            Field(x => x.Address_line);
            Field(x => x.Admin_district);
            Field(x => x.Admin_district2);
            Field(x => x.Locality);
            Field(x => x.Postal_code);
            Field(x => x.Country);
            Field(x => x.Name);
            Field(x => x.Image);
            Field(x => x.Legal_name);
            Field<ListGraphType<StringGraphType>>("alt_names");
            Field(x => x.Jurisdiction);
            Field(x => x.Primary_activity_owner);
            Field(x => x.Primary_activity_builder);
            Field(x => x.Primary_activity_design);
            Field(x => x.Primary_activity_manufacturer);
            Field(x => x.Primary_activity_operator);
            Field(x => x.Primary_activity_verifier);
            Field(x => x.Primary_activity_industry_association);
            Field(x => x.Primary_activity_other);
            Field(x => x.Primary_activity_forest_practices_certification);
            Field(x => x.Primary_activity_digitization_qa);
            Field(x => x.Primary_activity_sustainability_consulting);
            Field(x => x.Tax_id);
            Field(x => x.Website);
            Field(x => x.Transparency_catalog_link);
            Field(x => x.Email);
            Field(x => x.Org_type);
            Field(x => x.Currency);
            Field(x => x.Enterprise);
            Field(x => x.Parent);
            Field(x => x.Gwp_contact);
            Field(x => x.User_group_employees);
            Field(x => x.Primary_sustainability_contact);
        }
    }
}
