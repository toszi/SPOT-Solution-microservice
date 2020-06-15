using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class PlantLocationType : ObjectGraphType<PlantLocation>
    {
        public PlantLocationType()
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
            Field(x => x.LocalName, nullable: true);
            Field(x => x.CountrySubdivisionName);
        }
    }
}
