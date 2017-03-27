using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParallelProgramming.IO.implementation
{
    public class WeatherServiceConsumer
    {
        public static async void ParallelComputing(List<string> cities)
        {
            List<Task<Weather>> tasks = cities.Select(city => WeatherService.GetWeatherAsync(city))
                                  .ToList();

            while (tasks.Count() > 0)
            {
                Task<Weather> completed = await Task.WhenAny(tasks);

                var result = completed.Result;
                //compute weather result here 

                tasks.Remove(completed);
            }
        }

        public static void SequencialComputting(List<string> cities)
        {
            foreach (var city in cities)
            {
                var result = WeatherService.GetWeatherAsync(city).GetAwaiter().GetResult();

                //compute weather result here
            }
        }
    }
}
