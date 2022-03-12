using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using System.Text;

namespace BenchmarkTest
{
    [MemoryDiagnoser]
    [SimpleJob(RuntimeMoniker.Net461)]
    [SimpleJob(RuntimeMoniker.Net50)]
    public class StringVsStringBuilder
    {
        [Benchmark]
        public void ConcatenationStrings()
        {
            var @string = string.Empty;

            for (var i = 0; i < 1000; i++)
                @string += i;

        }

        [Benchmark(Baseline = true)]
        public void StringBuilders()
        {
            var stringBuilder = new StringBuilder();

            for (var i = 0; i < 1000; i++)
                stringBuilder.Append(i);

        }

    }
}
