using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(x => x.Id);
            Field(x => x.CreatedOn);
            Field(x => x.UpdatedOn);
            Field(x => x.Name);
            Field(x => x.DisplayName);
            Field(x => x.Masterformat);
            Field(x => x.Description);
            Field(x => x.DeclaredUnit);
            Field(x => x.MassPerDeclaredUnit);
            Field(x => x.BetaOnly);
            Field(x => x.Draft);
            Field(x => x.Parents);
            Field<ListGraphType<CategoryType>>("subcategories");
            Field<ListGraphType<CategoryType>>("foreigncategories");
            Field(x => x.ClfGwpBaseline);
        }
    }
}
