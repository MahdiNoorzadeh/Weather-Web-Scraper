using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Scraper.Interfaces;

namespace Web_Scraper.Classes
{
    public class WeatherService : IWeatherService
    {
        private readonly IHtmlParser _htmlParser;
        private readonly IHttpClient _httpClient;

        public WeatherService(IHttpClient httpClient, IHtmlParser htmlParser)
        {
            _httpClient = httpClient;
            _htmlParser = htmlParser;
        }
        public WeatherReport GetWeatherReport()
        {
            string weatherUrl = "https://weather.com/weather/today/l/02f681d8b529f988984de40a7c9c57f9b69f98ae58d86b1de3eb4e01499e3d29";
            string html = _httpClient.Get(weatherUrl);
            return _htmlParser.Parse(html);
        }

    }
}
