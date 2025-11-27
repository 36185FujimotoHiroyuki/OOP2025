using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkiApp
{
    public class CurrentWeatherResponse {
 
        public CurrentWeather? current { get; set; }

     
        public int utc_offset_seconds { get; set; }

    
        public Daily? daily { get; set; }
    }
}

