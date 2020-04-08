using GraphQL.Types;
using GraphQLSimpleTalk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Queries.Types
{
    public class PostType : ObjectGraphType<Post>
    {
        public PostType()
        {
            Field(x => x.Date);
            Field(x => x.Id);
            Field(x => x.Description);
            Field(x => x.Title);
            Field(x => x.Url);
            Field<AuthorType>("Author");
            Field<RatingType>("Rating");
            Field<ListGraphType<CommentType>>("Comments");
            Field(x => x.Categories, nullable: true);
        }
    }
}
