using System.Collections.Generic;

namespace ControlDashboard.Data
{
    public class Subcategory
    {
        public string SubcategoryName { get; set; }
        public string DocID { get; set; }
        public List<FeatureList> Features { get; set; }

        public Subcategory()
        {

        }
    }
}
