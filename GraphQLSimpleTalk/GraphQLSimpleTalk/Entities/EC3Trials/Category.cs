using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLSimpleTalk.Entities.EC3Trials
{
    public class Category
    {
        public string id { get; set; }
        public DateTime created_on { get; set; }
        public DateTime updated_on { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
        public string masterformat { get; set; }
        public string description { get; set; }
        public string declared_unit { get; set; }
        public string mass_per_declared_unit { get; set; }
        public bool beta_only { get; set; }
        public bool draft { get; set; }
        public object parents { get; set; }
        public object subcategories { get; set; }
        public object foreign_subcategories { get; set; }
        public string clf_gwp_baseline { get; set; }
    }
}
