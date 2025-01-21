using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lekce_13_HW
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
