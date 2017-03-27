using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ParallelProgramming.IO.implementation
{
    public class WeatherService
    {
        public static async Task<Weather> GetWeatherAsync(string city)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.CacheControl = new CacheControlHeaderValue
            {
                NoCache = true
            };
            string response = await httpClient.GetStringAsync("http://samples.openweathermap.org/data/2.5/weather?q=" + city + "&appid=66e7aab3cd5a9044aa478a99354b75c2");
            dynamic weather = JObject.Parse(response);
            return new Weather
            {
                City = city,
                TempratureCelsius = weather.main.temp - 273,
                Humidity = weather.main.humidity,
                Description = weather.weather[0].description
            };
        }
    }
}
