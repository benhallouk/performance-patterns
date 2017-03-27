using NUnit.Framework;
using ParallelProgramming.Data_Parallelism.Implementation;

namespace ParallelProgramming.Data_Parallelism
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void When_Parallelism_Not_Used()
        {
            PrimeGenerator.AllPrimes(1, 10000);
        }

        [Test]
        public void When_Parallelism_And_Lock_Is_Used()
        {
            PrimeGenerator.AllPrimesWithLock(1, 10000);
        }

        [Test]
        public void When_Parallelism_And_Aggregation_Is_Used()
        {
            PrimeGenerator.AllPrimesWithAggregation(1, 10000);
        }
    }
}
