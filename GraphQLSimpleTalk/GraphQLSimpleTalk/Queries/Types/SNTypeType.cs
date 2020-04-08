using GraphQL.Types;
using GraphQLSimpleTalk.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Queries.Types
{
    public class SNTypeType : EnumerationGraphType<SNType>
    {
        public SNTypeType()
        {
            Name = "SNTypeType";
        }
    }
}
