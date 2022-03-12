using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BenchmarkTest
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net461)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public class ListArray
    {
        private const int COUNT = 10_000;


        [Benchmark]
        public void AddToList()
        {
            var list = new List<int>();

            for (var i = 0; i < COUNT; i++)
                list.Add(i);

        }

        [Benchmark]
        public void FillArray()
        {
            var arr = new int[COUNT];

            for (var i = 0; i < COUNT; i++)
                arr[i] = i;
        }

        [Benchmark]
        public void AddToResizedArray()
        {
            var arr = new int[0];

            for (var i = 0; i < COUNT; i++)
            {
                Array.Resize(ref arr, i + 1);
                arr[i] = i;
            }
        }

        [Benchmark]
        public void ConcatArray()
        {
            var arr = new int[0];

            for (var i = 0; i < COUNT; i++)
                arr = arr.Concat(new int[] { i }).ToArray();
        }

        [Benchmark(Baseline = true)]
        public void ConvertArrayToList()
        {
            var arr = new int[0];

            var list = arr.ToList();

            for (var i = 0; i < COUNT; i++)
                list.Add(i);

            arr = list.ToArray();
        }

        [Benchmark]
        public void ConvertArrayToListEveryTime()
        {
            var arr = new int[0];

            for (var i = 0; i < COUNT; i++)
            {
                var list = arr.ToList();
                list.Add(i);
                arr = list.ToArray();
            }
        }
    }
}
