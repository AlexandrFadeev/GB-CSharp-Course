using System;
using AverageTemperature;

namespace MonthName
{
    enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    class Program
    {
        static void Main(string[] args)
        {
            Print print = new Print();
            print.ShowChooseMonthMessage();

            string userInput = Console.ReadLine();
            if (int.TryParse(userInput, out var number))
            {
                ShowMonthName(number);
            }
        }

        static void ShowMonthName(int monthNumber)
        {
            var monthsLenght = Enum.GetNames(typeof(Month)).Length;
            if (monthNumber < 1 || monthNumber > monthsLenght)
            {
                throw new Exception($"Month number must be in range from 1 to {monthNumber}");
            }
            
            Console.WriteLine($"Selected month is: {(Month)monthNumber}");
        }
    }
}