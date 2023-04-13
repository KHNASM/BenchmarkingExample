using BenchmarkDotNet.Running;

namespace BenchmarkingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var results = BenchmarkRunner.Run<Benchmark>();
        }
    }
}