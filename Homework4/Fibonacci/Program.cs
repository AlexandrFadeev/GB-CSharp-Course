using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
            program.PrintFibonacciSequence(0, 1, 100, true);
        }

        private void PrintFibonacciSequence(long previousResult, long result, int numberOfSteps, bool isInitial)
        {
            if (numberOfSteps <= 0)
            {
                return;
            }
            
            var sum = previousResult + result;
            // If sum has negative value, that means value is overflowed
            if (sum < 0)
            {
                Console.WriteLine("Stop execution. Fibonacci number is overflowed");
                return;
            }

            if (isInitial)
            {
                Console.WriteLine($"{previousResult}");
                Console.WriteLine($"{result}");
            }

            Console.WriteLine($"{previousResult + result}");
            PrintFibonacciSequence(result, sum, numberOfSteps - 1, false);
        }
    }
}