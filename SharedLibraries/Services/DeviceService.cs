using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Devices.Client;
using Newtonsoft.Json;
using SharedLibraries.Models;

namespace SharedLibraries.Services
{
    public static class DeviceService
    {
        //randomfunktionen
       private static readonly Random rnd = new Random();
       public static async Task SendMessageAsync(DeviceClient deviceClient)
        {
            
            while(true)
            {
                var data = new TemperatureModel
                {

                    Temperature = rnd.Next(20, 30),
                    Humidity = rnd.Next(40, 50),
                };

                // JSON = {"temperature": 20, "humidity": 44}
                var json = JsonConvert.SerializeObject(data);

                //meddelandet vi vill skicka kallas payload där vi formatterar meddelandet i azure devices client med en encoding.utf8
                var payload = new Message(Encoding.UTF8.GetBytes(json));
                await deviceClient.SendEventAsync(payload);


                Console.WriteLine($"Message sent: {json}");
                await Task.Delay(60 * 1000);
            }
        }

    }
}
