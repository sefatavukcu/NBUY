﻿using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class CapitalInfo
    {
        [JsonPropertyName("latlng")]
        public double[] LatLng { get; set; }
    }
}