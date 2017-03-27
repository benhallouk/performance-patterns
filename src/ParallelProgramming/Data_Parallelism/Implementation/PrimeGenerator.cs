using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ParallelProgramming.Data_Parallelism.Implementation
{
    public class PrimeGenerator
    {
        private static bool IsPrime(uint n)
        {
            if (n % 2 == 0 && n != 2) return false;
            uint root = (uint)Math.Ceiling(Math.Sqrt(n));
            for (uint i = 3; i <= root; i += 2)
            {
                if (n % i == 0 && n != i) return false;
            }
            return true;
        }

        public static List<uint> AllPrimes(uint from, uint to)
        {
            List<uint> result = new List<uint>();
            for (uint i = from; i <= to; ++i)
            {
                if (IsPrime(i)) result.Add(i);
            }
            return result;
        }

        public static List<uint> AllPrimesWithLock(uint from, uint to)
        {
            List<uint> result = new List<uint>();

            Parallel.For((int)from, (int)to, i =>
            {
                if (IsPrime((uint)i))
                {
                    lock (result)
                    {
                        result.Add((uint)i);
                    }
                }
            });
            return result;
        }

        public static List<uint> AllPrimesWithAggregation(uint from, uint to)
        {
            List<uint> result = new List<uint>();

            Parallel.For((int)from, (int)to,
                () => new List<uint>(),
                (i, pls, local) =>
                {
                    if (IsPrime((uint)i))
                    {
                        local.Add((uint)i);
                    }
                    return local;
                },
                local =>
                {
                    lock (result)
                    {
                        result.AddRange(local);
                    }
                });

            return result;
        }
    }
}
