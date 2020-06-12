using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLConsumingClient.Entities
{
    public class Material
    {        
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //Z stands for standard deviation
        public float Gwp_z { get; set; }
        public string Pct80_gwp_per_category_declared_unit { get; set; }
        public ConcreteScmDetails Concrete_scm_details { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Plant Plant { get; set; }
    }
}
