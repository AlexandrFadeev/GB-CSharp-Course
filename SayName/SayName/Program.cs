using System;

namespace SayName
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            DateTime date = DateTime.Today;
            string dateString = date.ToString("dd MMMM yyyy");

            Console.WriteLine($"Hello {userInput}, today is {dateString}");
            Console.WriteLine("Press any key to close this window . . .");

            // This need to keep console window open until user will press any key afer programm display message
            Console.ReadLine();
        }
    }
}
