using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(x => x.Id);
            Field(x => x.Created_on);
            Field(x => x.Updated_on);
            Field(x => x.Name);
            Field(x => x.Display_name);
            Field(x => x.Masterformat);
            Field(x => x.Description);
            Field(x => x.Declared_unit);
            Field(x => x.Mass_per_declared_unit);
            Field(x => x.Beta_only);
            Field(x => x.Draft);
            Field(x => x.Parents);
            Field<ListGraphType<CategoryType>>("subcategories");
            Field<ListGraphType<CategoryType>>("foreign_subcategories");
            Field(x => x.Clf_gwp_baseline);
        }
    }
}
