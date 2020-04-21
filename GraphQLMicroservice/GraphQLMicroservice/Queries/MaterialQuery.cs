using GraphQL.Types;
using GraphQLMicroservice.Queries.Types;
using GraphQLMicroservice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Queries
{
    public class MaterialQuery : ObjectGraphType
    {
        public MaterialQuery(EC3Service ec3Service)
        {
            Field<ListGraphType<MaterialType>>(
                "materials", "Query for all materials from EC3",
                resolve: context => ec3Service.GetAllMaterials()
                );
        }
    }
}
