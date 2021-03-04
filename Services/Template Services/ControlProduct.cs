using ControlDashboard.Data;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ControlDashboard.Services.Template_Services
{
    public class ControlProduct
    {
        private string address = "ControlProducts";
        private string link;

        public ControlProduct(string link)
        {
            this.link = link;
        }

        public async Task<List<Product>> GetAll()
        {
            string url = link + address;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<Product>>(response.Content);
        }

        public async Task<Product> GetOne(string id)
        {
            string url = link + address + "/" + id;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<Product>(response.Content);
        }

        public async Task<bool> AddNew(Product product)
        {
            string url = link + address;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string body = JsonConvert.SerializeObject(product);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Modify(string id, Product product)
        {
            string url = link + address + "/" + id;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            string body = JsonConvert.SerializeObject(product);
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Delete(string id)
        {
            string url = link + address + "/" + id;
            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            request.AddParameter("text/plain", "", ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
    }
}
