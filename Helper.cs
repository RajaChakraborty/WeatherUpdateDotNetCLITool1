using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WeatherUpdate.Model;

namespace WeatherUpdate
{
    public static class Helper
    {
        public static List<CityCordinate> GetAllCityCordinates()
        {
            var mainpath = AppDomain.CurrentDomain.BaseDirectory;

            string text = File.ReadAllText(mainpath + "\\CityCordinates.json");
            var allCities = JsonSerializer.Deserialize<List<CityCordinate>>(text);

            return allCities;
        }

        public static CityCordinate GetCityDetails(string enteredCity, List<CityCordinate> allCities)
        {
            var city = allCities.Where(c => c.City.ToUpper() == enteredCity.ToUpper()).FirstOrDefault();
            return city;
        }

        public static async Task<WeatherRoot> GetWeatherDetailsAsync(string latitude, string longitude)
        {
            string apiUrl = $"https://api.open-meteo.com/v1/forecast?latitude={latitude}&longitude={longitude}&current_weather=true";
            WeatherRoot weatherDetails = null; ;

            HttpClient client = new HttpClient();
            Console.WriteLine();
            var response = await client.GetStringAsync(apiUrl);

            if (response != null)
            {
                weatherDetails = JsonSerializer.Deserialize<WeatherRoot>(response);
            }
            return weatherDetails;
        }
    }
}
