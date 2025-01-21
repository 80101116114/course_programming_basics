using System.Text.Json;

namespace Lekce_13_HW
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Data z webové služby:");
            await GetPublicApiDataAsync();
        }

        private static async Task GetPublicApiDataAsync()
        {
            try
            {
                using HttpClient client = new HttpClient();
                const string apiKlic = "acdcb1f9791f433b9ef183142252101";
                const string mesto = "Prague";
                string url = $"https://api.weatherapi.com/v1/current.json?key={apiKlic}&q={mesto}&aqi=no";

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Odpověď z API:");
                Console.WriteLine(responseBody);
                DeserializacePocasi(responseBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Nastala chyba: {ex.Message}");
            }
        }

        private static void DeserializacePocasi(string jsonData)
        {
            try
            {
                var weatherData = JsonSerializer.Deserialize<WeatherDTO>(jsonData);

                if (weatherData != null)
                {
                    Console.WriteLine($"Počasí v {weatherData.Location.Name}:");
                    Console.WriteLine($"Teplota: {weatherData.Current.TempC}°C");
                    Console.WriteLine($"Stav: {weatherData.Current.Condition.Text}");
                }
                else
                {
                    Console.WriteLine("Nepodařilo se deserializovat data.");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Chyba při deserializaci JSON: {ex.Message}");
            }
        }
    }
}
