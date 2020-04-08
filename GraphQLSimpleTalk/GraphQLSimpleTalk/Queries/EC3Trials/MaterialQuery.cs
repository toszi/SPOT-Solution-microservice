using GraphQL.Types;
using GraphQLSimpleTalk.Queries.Types.EC3Trials;
using GraphQLSimpleTalk.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Queries.EC3Trials
{
    public class MaterialQuery : ObjectGraphType
    {
        public MaterialQuery(EC3Service ec3Service)
        {
            /*
            Field<ListGraphType<MaterialType>>(
                name: "materials",
                resolve: context => {
                    return ec3Service.GetAllMaterials();
                }
            );
            */
            Field<ListGraphType<MaterialType>>(
                "materials",
                resolve: context => ec3Service.GetAllMaterials()
            );
        }
    }
}
