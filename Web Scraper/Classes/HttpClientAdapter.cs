using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Scraper.Interfaces;

namespace Web_Scraper.Classes
{
    public class HttpClientAdapter : IHttpClient
    {
        private readonly HttpClient _httpClient;

        public HttpClientAdapter()
        {
            _httpClient = new HttpClient();
        }
        public string Get(string url)
        {
            return _httpClient.GetStringAsync(url).Result;
        }
    }
}
