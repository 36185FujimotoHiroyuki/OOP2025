using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkiApp
{
    public class CurrentWeather {
        public double temperature { get; set; }
        public double windspeed { get; set; }
       
        [System.Text.Json.Serialization.JsonPropertyName("relative_humidity_2m")]
        public double relative_humidity { get; set; }
        public int weathercode { get; set; }
        public string time { get; set; }
    }
}
