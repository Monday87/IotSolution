using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using UWP_Uppgift4.Helpers;
using Microsoft.Azure.Devices.Client;
using SharedLibraryUniversalWindow.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_Uppgift4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }



        public WeatherList weatherList = new WeatherList();

        public void btnClickHere_Click_1(object sender, RoutedEventArgs e)
        {
           AzureHelpers.SendRecieveMessageAsync();

            try
            {
                lvWeatherList.ItemsSource = lvWeatherList;

            }
            catch
            {

            }
        }
    }
}
