using System;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any integer number");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out var number))
            {
                string resultString = number % 2 == 0 ? "Even" : "Odd";
                Console.WriteLine($"Number {number} is {resultString}");
                return;
            }
            
            Console.WriteLine("Something went wrong. Perhaps you've entered wrong character");
        }
    }
}