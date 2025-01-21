using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lekce_13_HW
{
    public class Current
    {
        [JsonPropertyName("temp_c")]
        public double TempC { get; set; }
        [JsonPropertyName("condition")]
        public Condition Condition { get; set; }
    }
}
