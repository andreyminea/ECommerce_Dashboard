using System;
using System.Collections.Generic;

namespace ControlDashboard.Data
{
    public class Product
    {
        public string ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
        public int TVA { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string CategoryID { get; set; }
        public string SubcategoryID { get; set; }
        public List<string> Pictures { get; set; }
        public ProductFeatures FeaturesLists { get; set; }

        public Product()
        {
        }

        public bool CheckGeneralInfo()
        {
            bool result = true;
            result = result && !String.IsNullOrWhiteSpace(ProductID);
            result = result && !String.IsNullOrWhiteSpace(Name);
            result = result && !String.IsNullOrWhiteSpace(Brand);
            result = result && !String.IsNullOrWhiteSpace(CategoryID);
            result = result && !String.IsNullOrWhiteSpace(SubcategoryID);
            result = result && (Price > 0);
            return result;
        }
        public bool CheckRest()
        {
            bool result = true;
            result = result && !String.IsNullOrWhiteSpace(Description);
            result = result && Pictures.Count > 0;
            return result;
        }
    }
}
