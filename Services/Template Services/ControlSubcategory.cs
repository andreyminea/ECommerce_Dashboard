using ControlDashboard.Data;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlDashboard.Services.Subservices
{
    public class ControlSubcategory
    {
        private string address = "ControlSubcategory";
        private string link;

        public ControlSubcategory(string link)
        {
            this.link = link;
        }

        public async Task<List<Subcategory>> GetAll(string categ)
        {
            var uri = link + address + "/" + categ;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<Subcategory>>(response.Content);
        }

        public async Task<bool> AddNew(string categ, string name)
        {
            var uri = link + address + "/" + categ;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string body = "{\r\n    \"subcategoryName\":\"" + name + "\"\r\n}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Rename(string categ, string oldName, string newName)
        {
            var uri = link + address + "/" + categ + "/" + oldName;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            string body = "{\r\n    \"subcategoryName\":\"" + newName + "\"\r\n}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Delete(string categ, string name)
        {
            var uri = link + address + "/" + categ + "/" + name;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
    }
}
