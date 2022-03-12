using BenchmarkDotNet.Running;

namespace BenchmarkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<FindItem>();
            //BenchmarkRunner.Run<StringVsStringBuilder>();
            //BenchmarkRunner.Run<ListArray>();
        }
    }
}
