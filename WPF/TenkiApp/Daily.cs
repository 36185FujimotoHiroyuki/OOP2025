using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenkiApp {
    public class Daily {
        public string[]? time { get; set; } 

     
        public double[]? temperature_2m_max { get; set; }
        public double[]? temperature_2m_min { get; set; }
        public double[]? weather_code { get; set; }
    }
}
