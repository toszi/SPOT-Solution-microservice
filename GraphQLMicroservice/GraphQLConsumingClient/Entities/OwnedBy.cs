using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLConsumingClient.Entities
{
    public class OwnedBy
    {
        public OwnedByLocation Location { get; set; }
        public string Name { get; set; }
    }
}
