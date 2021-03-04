using ControlDashboard.Services.Subservices;
using ControlDashboard.Services.Template_Services;

namespace ControlDashboard.Services
{
    public class APIManager
    {
        private string link = "https://localhost:44341/";//"https://controlapiiazon.azurewebsites.net/";
        public ControlCategory Category;
        public ControlSubcategory Subcategory;
        public ControlFeature Feature;
        public ControlProduct Product;

        public APIManager()
        {
            Category = new ControlCategory(link);
            Subcategory = new ControlSubcategory(link);
            Feature = new ControlFeature(link);
            Product = new ControlProduct(link);
        }

    }
}
