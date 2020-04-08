using GraphQL;
using GraphQL.Types;
using GraphQLSimpleTalk.Queries.EC3Trials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Schemas
{
    public class MaterialSchema : Schema
    {
        public MaterialSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<MaterialQuery>();
        }
    }
}
