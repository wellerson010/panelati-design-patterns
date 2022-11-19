using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facades
{
    public class HTTPFacade
    {
        public async static Task<T> Get<T>(string url, Dictionary<string, string> headers = null) where T:class
        {
            using (var client = new HttpClient())
            {
                if (headers != null)
                {
                    foreach (KeyValuePair<string, string> header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }

                HttpResponseMessage response = client.GetAsync(url).Result;
                string resultContent = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<T>(resultContent)!;
            }
        }

        public async static Task DownloadFile(string url, string path)
        {
            using (WebClient cliente = new WebClient())
            {
                cliente.DownloadFileAsync(new Uri(url), path);
            }
        }
    }
}
