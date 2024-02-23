using HtmlAgilityPack;
using System;
using System.Net.Http;
using Web_Scraper.Classes;
using Web_Scraper.Interfaces;

namespace WebScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeatherService weatherService = new WeatherService(new HttpClientAdapter(), new HtmlParser());
            WeatherReport report = weatherService.GetWeatherReport();

            Console.WriteLine("City: " + report.City);
            Console.WriteLine("Conditions: " + report.Condition);
            Console.WriteLine("Temperature: " + report.Temperature);
        }
    }
}