using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibraryUniversalWindow.Models
{
    public class WeatherModel
    {
        public string Temperature { get; set; }
        public string Humidity { get; set; }

        public WeatherModel()
        {
        
        }
        public WeatherModel(string temperature, string humidity)
        {
            Temperature = temperature;
            Humidity = humidity;

        }


    }
    
    
}
