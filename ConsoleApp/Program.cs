using System;
using Microsoft.Azure.Devices.Client;
using SharedLibraries.Models;
using SharedLibraries.Services;

namespace ConsoleApp
{
    class Program
    {
        //detta initierar DeviceClient
        private static readonly string _conn = "HostName=ec-win20-iothub-steven.azure-devices.net;DeviceId=consoleapp;SharedAccessKey=XGdu2yZYv64vz9obdSIiOdVHTmEo3OAGTdsNHJSBHPU=";
        //Det här är alltså IOT-devicen. Denna gör att man kopplar upp sig genom connectionstringen ovan. 
        //Så att applikation vet att den är kopplad mot denna device som finns i molnet.
        //MQTT-kommunikationsprotokoll. Finns olika. HTTP osv.
        //Den går att lägga i Deviceservice.cs
        private static readonly DeviceClient deviceClient = 
            DeviceClient.CreateFromConnectionString(_conn, TransportType.Mqtt);
        static void Main(string[] args)
        {

            DeviceService.SendMessageAsync(deviceClient).GetAwaiter();
            DeviceService.RecieveMessageAsync(deviceClient).GetAwaiter();

            Console.ReadKey();
        }

        
    }
}
