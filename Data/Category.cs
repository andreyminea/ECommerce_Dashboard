using System.Collections.Generic;

namespace ControlDashboard.Data
{
    public class Category
    {
        public string CategoryName { get; set; }
        public string DocID { get; set; }
        public List<Subcategory> Subcategories { get; set; }

        public Category()
        {
        }
    }
}
