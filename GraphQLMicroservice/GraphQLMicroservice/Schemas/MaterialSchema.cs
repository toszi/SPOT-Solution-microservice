using GraphQL;
using GraphQL.Types;
using GraphQLMicroservice.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Schemas
{
    public class MaterialSchema : Schema
    {
        public MaterialSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<MaterialQuery>();
        }
    }
}
