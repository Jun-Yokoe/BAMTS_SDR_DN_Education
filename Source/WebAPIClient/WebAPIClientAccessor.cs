using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;

namespace BAMTS.Internal
{
    public class WebAPIClientAccessor : WebAPIClientBase, IDataAccessor
    {
        public WebAPIClientAccessor(string serverName, int portNo, string controllerName, string protocol = "http", string rootPath = "api", string mediaType = "application/json") 
            : base(serverName, portNo, controllerName, protocol, rootPath, mediaType) { }
        public T GetData<T>(string methodName)
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync($"{this.URIBase}/{methodName}").GetAwaiter().GetResult();
                if (response.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
                else
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }
        public IList<RecEmployeeAll> GetEmployeeAll()
        {
            using (HttpClient client = new HttpClient())
            {
                var response = client.GetAsync($"{this.URIBase}/GetEmployeeAll").GetAwaiter().GetResult();
                if (response.StatusCode == HttpStatusCode.OK)
                    return JsonConvert.DeserializeObject<IList<RecEmployeeAll>>(response.Content.ReadAsStringAsync().Result);
                else
                    throw new Exception(response.Content.ReadAsStringAsync().Result);
            }
        }
        public void UpdateEmployeeAll(IList<RecEmployeeAll> list)
        {
            using (HttpClient client = new HttpClient())
            {
                var jsonString = JsonConvert.SerializeObject(list);
                var content = new StringContent(jsonString, Encoding.UTF8, @"application/json");
                using (var response = client.PostAsync($"{this.URIBase}/UpdateEmployeeAll", content).GetAwaiter().GetResult())
                {
                    if (response.IsSuccessStatusCode == false)
                    {
                        throw new Exception(response.ReasonPhrase);
                    }
                }
            }
        }
    }
}
