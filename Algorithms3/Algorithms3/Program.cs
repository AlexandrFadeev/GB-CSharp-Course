
using System;
using BenchmarkDotNet.Running;

namespace Algorithms3
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }
}

// Benchmark results...
/*
 
    |                Method |      Mean |     Error |    StdDev |
    |---------------------- |----------:|----------:|----------:|
    |   TestClassFloatPoint | 12.150 ns | 0.0529 ns | 0.0442 ns |
    |  TestClassDoublePoint | 13.484 ns | 0.0706 ns | 0.0661 ns |
    |  TestStructFloatPoint | 11.897 ns | 0.0309 ns | 0.0258 ns |
    | TestStructDoublePoint |  2.529 ns | 0.0081 ns | 0.0067 ns |

*/