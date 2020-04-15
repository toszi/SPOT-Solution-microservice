using GraphQL.Types;
using GraphQLMicroservice.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries.Types
{
    public class ScmDetailsType : ObjectGraphType<ScmDetails>
    {
        public ScmDetailsType()
        {
            Field(x => x.FlyAsh);
            Field(x => x.Slag);
        }
    }
}
