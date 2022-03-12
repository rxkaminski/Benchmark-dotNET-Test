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
    public class FindItem
    {
        public const int COUNT = 10_000;
        private List<Item> list = new List<Item>();
        private Item[] array = new Item[0];
        private Dictionary<string, Item> dictionaryString = new Dictionary<string, Item>();
        private Dictionary<Tuple<string, string, string>, Item> dictionaryTuple = new Dictionary<Tuple<string, string, string>, Item>();
        private string find1, find2, find3;


        [GlobalSetup]
        public void Setup()
        {
            find1 = "9999";
            find2 = "9999";
            find3 = "9999";


            for (var i = 0; i < COUNT; i++)
            {
                var item = new Item()
                { 
                    Value1 = i.ToString(), 
                    Value2 = i.ToString(), 
                    Value3 = i.ToString(), 
                    Value4 = i.ToString() 
                };

                list.Add(item);

                //dictionary with string key 
                var key = $"{item.Value1}_{item.Value2}_{item.Value3}";
                dictionaryString.Add(key, item);

                //dictionaty with tuple key
                var keyTuple = new Tuple<string, string, string>(item.Value1, item.Value2, item.Value3);
                dictionaryTuple.Add(keyTuple, item);
            }

            array = list.ToArray();
        }

        [Benchmark]
        public void FindInList()
        {
            var item = list.First(i => i.Value1 == find1 && i.Value2 == find2 && i.Value3 == find3);
        }

        [Benchmark]
        public void FindInArray()
        {
            var item = array.First(i => i.Value1 == find1 && i.Value2 == find2 && i.Value3 == find3);
        }

        [Benchmark(Baseline = true)]
        public void FindInDicString()
        {
            var key = $"{find1}_{find2}_{find3}";
            var item = dictionaryString[key];
        }

        [Benchmark]
        public void FindInDicTuple()
        {
            var keyTuple = new Tuple<string, string, string>(find1, find2, find3);
            var item = dictionaryTuple[keyTuple];
        }
    }
}
