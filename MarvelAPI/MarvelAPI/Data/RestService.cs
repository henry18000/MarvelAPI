using MarvelAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MarvelAPI.Data
{
   public class RestService:IRestService
    {
        HttpClient _client;

        public List<Marvel> MarvelList { get; private set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<List<Marvel>> RefreshDataAsync()
        {
            MarvelList = new List<Marvel>();

            var uri = new Uri(string.Format(Constants.MarvelUrl, string.Empty));
 
            try
            {
                for (int i=0;i<30;i++)
                {
                    var response = await _client.GetAsync(uri);
                    Debug.WriteLine("XXXX: " + response.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        // Debug.WriteLine(content);
                        Marvel marvel = JsonConvert.DeserializeObject<Marvel>(content);
                        Debug.WriteLine(marvel);
                        MarvelList.Add(marvel);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return MarvelList;
        }
    }
}
