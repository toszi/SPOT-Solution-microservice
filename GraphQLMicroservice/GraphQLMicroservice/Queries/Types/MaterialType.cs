using GraphQL.Types;
using GraphQLMicroservice.Entities;

namespace GraphQLMicroservice.Queries.Types
{
    public class MaterialType : ObjectGraphType<Material>
    {
        public MaterialType()
        {
            Field(x => x.Id);
            Field(x => x.CreatedOn);
            Field(x => x.CreatedBy);
            Field(x => x.UpdatedOn);
            Field(x => x.UpdatedBy);
            Field<OwnerType>("owner");
            Field(x => x.Name);
            Field(x => x.AlternativeNames);
            Field(x => x.Description);
            Field(x => x.DatasheetLink);
            Field(x => x.Gwp);
            Field(x => x.GwpPerCategoryDeclaredUnit);
            Field(x => x.GwpPerKg);
            Field(x => x.GwpZ);
            Field(x => x.Pct80GwpPerCategoryDeclaredUnit);
            Field(x => x.ConservativeEstimate);
            Field(x => x.BestPractice);
            Field(x => x.ConcreteCompressiveStrength28D);
            Field(x => x.ConcreteCompressiveStrengthOther);
            Field(x => x.ConcreteCompressiveStrengthOtherD, nullable: true);
            Field(x => x.ConcreteFlexionStrength);
            Field(x => x.ConcreteSlump);
            Field(x => x.ConcreteMinSlump);
            Field(x => x.ConcreteMaxSlump);
            Field(x => x.ConcreteAggregateSizeMax);
            Field(x => x.ConcreteMinPipelineSize);
            Field(x => x.ConcreteWCRatio);
            Field(x => x.ConcreteScmMin);
            Field(x => x.ConcreteScmMax);
            Field<ConcreteScmDetailsType>("scnmdetails");
        }
    }
}
