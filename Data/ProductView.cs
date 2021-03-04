using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlDashboard.Data
{
    public class ProductView
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Category { get; set; }
        public string Subcategory { get; set; }

        public ProductView(Product product, List<Category> categories)
        {
            ProductID = product.ProductID;
            Name = product.Name;
            Stock = product.Stock;
            var category = categories.Find(x => x.DocID.Equals(product.CategoryID));
            Category = category.CategoryName;
            var subcategory = category.Subcategories.Find(x => x.DocID.Equals(product.SubcategoryID));
            Subcategory = subcategory.SubcategoryName;
        }
    }
}
