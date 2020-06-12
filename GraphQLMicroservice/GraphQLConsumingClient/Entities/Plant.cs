using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLConsumingClient.Entities
{
    public class Plant
    {
        public PlantLocation Location { get; set; }
        public string Name { get; set; }
        public List<string> Alt_names { get; set; }
        public OwnedBy Owned_by { get; set; }
    }
}
