using GraphQL.Types;
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
        readonly EC3Service ec3Service = new EC3Service();
        public MaterialQuery()
        {
            Field<ListGraphType<MaterialType>>(
                "materials", "Query for all materials from EC3", 
                resolve: context => ec3Service.GetAllMaterials()
                );
        }
    }
}
