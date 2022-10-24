using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ElevateEvansvilleUI.API
{
    class APIClient
    {
        public HttpClient client;

        public static string BaseUrl { get; private set; } = "https://elevateevansvilleapi.azure-api.net";


        public static async Task<string> Get()
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", "9442156c132b491d86f3b191081b8a1a");
                HttpResponseMessage response = client.GetAsync("/Current").Result;
                if (response.IsSuccessStatusCode)
                {
                    return response.Content.ReadAsStringAsync().Result;
                }
                else
                {
                    var ResponseResult = await response.Content.ReadAsStringAsync();
                    return ResponseResult;
                }
            }
        }


    }


}
