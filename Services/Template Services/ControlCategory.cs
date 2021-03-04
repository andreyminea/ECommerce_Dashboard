using ControlDashboard.Data;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ControlDashboard.Services.Subservices
{
    public class ControlCategory
    {
        private string address = "ControlCategory";
        private string link;

        public ControlCategory(string link)
        {
            this.link = link;
        }

        public async Task<List<Category>> GetAll()
        {
            var uri = link + address;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<Category>>(response.Content);
        }

        public async Task<bool> AddNew(string name)
        {
            var uri = link + address;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string body = "{\r\n    \"categoryName\":\"" + name + "\"\r\n}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Rename(string oldName, string newName)
        {
            var uri = link + address + "/" + oldName;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            string body = "{\r\n    \"categoryName\":\"" + newName + "\"\r\n}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Delete(string name)
        {
            var uri = link + address + "/" + name;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
    }
}
