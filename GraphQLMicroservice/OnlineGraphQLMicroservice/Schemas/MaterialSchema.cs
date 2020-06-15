using GraphQL.Types;
using OnlineGraphQLMicroservice.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGraphQLMicroservice.Schemas
{
    public class MaterialSchema : Schema
    {
        public MaterialSchema()
        {
            Query = new MaterialQuery();
        }
    }
}
