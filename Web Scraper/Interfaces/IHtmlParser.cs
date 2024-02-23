using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_Scraper.Classes;

namespace Web_Scraper.Interfaces
{
   public interface IHtmlParser
    {
        WeatherReport Parse (string html);
    }
}
