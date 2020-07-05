using GraphQL.Types;
using OnlineGraphQLMicroservice.Interfaces;
using OnlineGraphQLMicroservice.Services;
using OnlineGraphQLMicroservice.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGraphQLMicroservice.Queries
{
    public class MaterialQuery : ObjectGraphType
    {
        private static readonly IEC3Service instance = EC3Service.Instance;
        public MaterialQuery()
        {
            Field<ListGraphType<MaterialType>>(
                "materials", "Query for all materials from EC3", 
                resolve: context => instance.getMaterialList()
                );
        }
    }
}
