using System;

namespace SeasonYear
{
    class Program
    {
        private enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            None
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter month number. It must be in range from 1 to 12");
            var userInput = Console.ReadLine();

            try
            {
                var monthNumber = Int32.Parse(userInput ?? throw new InvalidOperationException());
                var season = GetSeasonFromMonthNumber(monthNumber);
                if (season != Season.None)
                {
                    Console.WriteLine($"Season: {season}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine($"Failed to parse {userInput}");
            }
        }

        private static Season GetSeasonFromMonthNumber(int monthNumber)
        {
            switch (monthNumber)
            {
                case 12:
                case 1:
                case 2: return Season.Winter;
                case 3:
                case 4:
                case 5: return Season.Spring;
                case 6:
                case 7:
                case 8: return Season.Summer;
                case 9:
                case 10:
                case 11: return Season.Autumn;
                default: 
                    Console.WriteLine("Error: Please enter number in range 1 to 12");
                    return Season.None;
            }
        }
    }
}

/*
 * Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
 * На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
 * Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
 * Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
 * Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
*/