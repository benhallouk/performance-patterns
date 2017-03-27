using NUnit.Framework;
using ParallelProgramming.IO.implementation;
using System.Collections.Generic;

namespace ParallelProgramming.IO
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void When_Async_Is_Not_Used()
        {
            List<string> cities = new List<string>
            {
               "London",
               "Safi",
               "Warsaw"
            };

            WeatherServiceConsumer.SequencialComputting(cities);
        }

        [Test]
        public void When_Async_Is_Used()
        {
            List<string> cities = new List<string>
            {
               "London",
               "Safi",
               "Warsaw"
            };

            WeatherServiceConsumer.ParallelComputing(cities);
        }

    }
}
