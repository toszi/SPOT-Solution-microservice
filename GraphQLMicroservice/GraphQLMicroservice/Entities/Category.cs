using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMicroservice.Entities
{
    public class Category
    {
        public string Id { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public string Name { get; set; }
        public string DisplayName { get; set; }
        public string Masterformat { get; set; }
        public string Description { get; set; }
        public string DeclaredUnit { get; set; }
        public string MassPerDeclaredUnit { get; set; }
        public bool BetaOnly { get; set; }
        public bool Draft { get; set; }
        public string Parents { get; set; }
        public List<Category> Subcategories { get; set; }
        public List<Category> ForeignSubcategories { get; set; }
        public string ClfGwpBaseline { get; set; }
    }
}
