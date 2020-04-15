using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
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
