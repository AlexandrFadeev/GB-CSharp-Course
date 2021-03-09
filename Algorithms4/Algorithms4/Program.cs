

using BenchmarkDotNet.Running;

namespace Algorithms4
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}

// Benchmark results

/*
    * First run *
    |              Method |         Mean |     Error |    StdDev |
    |-------------------- |-------------:|----------:|----------:|
    | TestContainsInArray | 33,155.83 ns | 98.308 ns | 82.092 ns |
    |   TestContainsInSet |     19.26 ns |  0.102 ns |  0.085 ns |
    
    --------------------------------------------------------------
    * Second run *
    |              Method |         Mean |     Error |    StdDev |
    |-------------------- |-------------:|----------:|----------:|
    | TestContainsInArray | 33,111.50 ns | 89.427 ns | 74.676 ns |
    |   TestContainsInSet |     16.57 ns |  0.044 ns |  0.037 ns |
*/