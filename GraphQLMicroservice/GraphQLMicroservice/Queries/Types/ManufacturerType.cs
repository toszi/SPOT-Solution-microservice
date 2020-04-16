using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class ManufacturerType : ObjectGraphType<Manufacturer>
    {
        public ManufacturerType()
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
            Field(x => x.Jurisdiction, nullable: true);
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
            Field(x => x.TaxId, nullable: true);
            Field(x => x.Website);
            Field(x => x.TransparencyCatalogLink);
            Field(x => x.Email, nullable: true);
            Field(x => x.OrgType);
            Field(x => x.Currency, nullable: true);
            Field(x => x.Enterprise);
            Field(x => x.Parent, nullable: true);
            Field(x => x.GwpContact, nullable: true);
            Field(x => x.UserGroupEmployees, nullable: true);
            Field(x => x.PrimarySustainabilityContact, nullable: true);
        }
    }
}
