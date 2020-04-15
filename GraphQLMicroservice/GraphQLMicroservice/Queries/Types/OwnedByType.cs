using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class OwnedByType : ObjectGraphType<OwnedBy>
    {
        public OwnedByType()
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
            Field(x => x.Image);
            Field(x => x.LegalName);
            Field<ListGraphType<StringGraphType>>("alt_names");
            Field(x => x.Jurisdiction);
            Field(x => x.PrimaryActivityOwner);
            Field(x => x.PrimaryActivityBuilder);
            Field(x => x.PrimaryActivityDesign);
            Field(x => x.PrimaryActivityManufacturer);
            Field(x => x.PrimaryActivityOperator);
            Field(x => x.PrimaryActivityVerifier);
            Field(x => x.PrimaryActivityIndustryAssociation);
            Field(x => x.PrimaryActivityOther);
            Field(x => x.PrimaryActivityForestPracticesCertification);
            Field(x => x.PrimaryActivityDigitizationQa);
            Field(x => x.PrimaryActivitySustainabilityConsulting);
            Field(x => x.TaxId);
            Field(x => x.Website);
            Field(x => x.TransparencyCatalogLink);
            Field(x => x.Email);
            Field(x => x.OrgType);
            Field(x => x.Currency);
            Field(x => x.Enterprise);
            Field(x => x.Parent);
            Field(x => x.GwpContact);
            Field(x => x.UserGroupEmployees);
            Field(x => x.PrimarySustainabilityContact);
        }
    }
}
