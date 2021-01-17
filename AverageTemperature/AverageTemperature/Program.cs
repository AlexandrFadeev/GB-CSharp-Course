using System;
using AverageTemperature.model;

namespace AverageTemperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter minimum temperature");
            string minTemperatureString = Console.ReadLine();
            int minTemperature = IntegerFromString(minTemperatureString);
            
            Console.WriteLine("Please enter maximum temperature");
            string maxTemperatureString = Console.ReadLine();
            int maxTemperature = IntegerFromString(maxTemperatureString);
            
            AverageCalculator calculator = new AverageCalculator(new int[] {minTemperature, maxTemperature});
            
            Console.WriteLine($"Average temperature is {calculator.CalculatedAverage()}");
        }

        static int IntegerFromString(string stringValue)
        {
            try
            {
                return Int32.Parse(stringValue);
            }
            catch(FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            throw new InvalidOperationException("Input string was not in a correct format. Correct format is Integer number");
        }
    }
}
