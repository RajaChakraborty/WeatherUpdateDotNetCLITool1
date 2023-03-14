using System;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherUpdate
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter a city :");
            var enteredCity = Console.ReadLine();

            Start:
            while(string.IsNullOrEmpty(enteredCity))
            {
                Console.Write("Please enter a city: ");
                enteredCity = Console.ReadLine();
            }

            Console.WriteLine("Getting weather details......");
            var allCities = Helper.GetAllCityCordinates();
            var city = Helper.GetCityDetails(enteredCity, allCities);

            if (city == null)
            {
                Console.WriteLine("City you entered cannot be found. Try again with any other city");
                enteredCity = "";
                goto Start;
            }

            else
            {
                var weatherDetails = await Helper.GetWeatherDetailsAsync(city.Latitude, city.Longitude);
                if(weatherDetails!=null)
                {
                    Console.WriteLine();
                    Console.WriteLine("Current temperature: {0}", weatherDetails.CurrentWeather.Temperature);
                    Console.WriteLine("Current wind speed: {0}", weatherDetails.CurrentWeather.Windspeed);
                    Console.WriteLine("Current wind direction: {0}", weatherDetails.CurrentWeather.WindDirection);
                }
            }
        }
    }
}
