using ControlDashboard.Data;
using Newtonsoft.Json;
using RestSharp;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ControlDashboard.Services.Subservices
{
    public class ControlFeature
    {
        private string address = "ControlFeatures";
        private string link;

        public ControlFeature(string link)
        {
            this.link = link;
        }

        public async Task<List<FeatureList>> GetAll(string prefix)
        {
            var uri = link + address + "/" + prefix;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = await client.ExecuteAsync(request);
            return JsonConvert.DeserializeObject<List<FeatureList>>(response.Content);
        }

        public async Task<bool> AddNewList(string prefix, string name)
        {
            var uri = link + address + "/" + prefix;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/json");
            string body = "{\r\n    \"featureListName\":\"" + name + "\"\r\n}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> ModifyList(string prefix, FeatureList list)
        {
            var uri = link + address + "/" + prefix + "/" + list.FeatureListName;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.PUT);
            request.AddHeader("Content-Type", "application/json");
            string serializedList = JsonConvert.SerializeObject(list);
            request.AddParameter("application/json", serializedList, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }

        public async Task<bool> Delete(string prefix, string listName)
        {
            var uri = link + address + "/" + prefix + "/" + listName;
            var client = new RestClient(uri);
            client.Timeout = -1;
            var request = new RestRequest(Method.DELETE);
            IRestResponse response = await client.ExecuteAsync(request);
            return response.IsSuccessful;
        }
    }
}
