using System;
using System.Linq;

namespace NumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter number to find their sum. Numbers must be separated with `space`");
            var userInput = Console.ReadLine();

            if (userInput == null)
            {
                return;
            }

            var components = userInput.Split(' ');
            PrintSum(components);
        }

        private static void PrintSum(string[] components)
        {
            var sum = 0;

            foreach (var component in components)
            {
                if (int.TryParse(component, out var i))
                {
                    sum += i;
                }
            }
            
            Console.WriteLine($"Sum of elements: {sum}");
        }
    }
}