using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WeatherUpdate.Model
{
    public class CityCordinate
    {
        [JsonPropertyName("city")]
        public string City { get; set; }

        [JsonPropertyName("lat")]
        public string Latitude { get; set; }

        [JsonPropertyName("lng")]
        public string  Longitude { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("iso2")]
        public string CountryCode { get; set; }

        [JsonPropertyName("admin_name")]
        public string AdminName { get; set; }

        [JsonPropertyName("capital")]
        public string Capital { get; set; }

        [JsonPropertyName("population")]
        public string Population { get; set; }

        [JsonPropertyName("population_proper")]
        public string PopulationProper { get; set; }
    }
}
