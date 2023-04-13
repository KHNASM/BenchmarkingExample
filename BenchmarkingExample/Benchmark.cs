using BenchmarkDotNet.Attributes;
using System.Text;

[MemoryDiagnoser]
public class Benchmark
{
    [Benchmark]
    public void ConcatenateNumbersWithStringBuilder()
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10; i++)
        {
            sb.Append(i);
        }
    }

    [Benchmark]
    public void ConcatenateNumbersWithStringJoin()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            list.Add(i);

        }
        string concatenatedPrimes = string.Join("", list);
        
    }
}