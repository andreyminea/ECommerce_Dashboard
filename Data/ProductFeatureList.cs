using System.Collections.Generic;

namespace ControlDashboard.Data
{
    public class ProductFeatureList
    {
        public string Name { get; set; }
        public Dictionary<string, string> Features { get; set; }

        public ProductFeatureList()
        {
        }
    }
}