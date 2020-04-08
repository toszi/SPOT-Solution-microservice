using GraphQL.Types;
using GraphQLSimpleTalk.Entities.EC3Trials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Queries.Types.EC3Trials
{
    public class OwnerType : ObjectGraphType<Owner>
    {
        public OwnerType()
        {
            Field(x => x.UserId);
            Field(x => x.Name);
        }
    }
}
