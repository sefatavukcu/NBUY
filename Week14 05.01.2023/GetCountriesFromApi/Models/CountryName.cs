using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace GetCountriesFromApi.Models
{
    public class CountryName : Translations
    {
        [JsonPropertyName("nativeName")]
        public Dictionary<string,Translations> NativeName { get; set; }
    }
}