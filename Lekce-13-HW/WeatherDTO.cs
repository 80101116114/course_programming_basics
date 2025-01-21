using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lekce_13_HW
{
    public class WeatherDTO
    {

        [JsonPropertyName("location")]
        public Location Location { get; set; }
        [JsonPropertyName("current")]
        public Current Current { get; set; }

    }
}
