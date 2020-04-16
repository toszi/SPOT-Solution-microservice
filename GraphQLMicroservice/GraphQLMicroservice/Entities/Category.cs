using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string Created_on { get; set; }
        public string Updated_on { get; set; }
        public string Name { get; set; }
        public string Display_name { get; set; }
        public string Masterformat { get; set; }
        public string Description { get; set; }
        public string Declared_unit { get; set; }
        public string Mass_per_declared_unit { get; set; }
        public bool Beta_only { get; set; }
        public bool Draft { get; set; }
        public string Parents { get; set; }
        public List<Category> Subcategories { get; set; }
        public List<Category> Foreign_subcategories { get; set; }
        public string Clf_gwp_baseline { get; set; }
    }
}
