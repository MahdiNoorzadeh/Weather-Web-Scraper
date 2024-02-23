using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Scraper.Interfaces
{
   public interface IHttpClient
    {
        string Get(string url);
    }
}
