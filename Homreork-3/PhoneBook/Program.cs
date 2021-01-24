using System;

namespace PhoneBook
{
    class Program
    {
        private const int Rows = 5;
        private const int Columns = 2;
        static void Main(string[] args)
        {
            // Hardcoded two dimensional array... 
            var example = new [,]
            {
                {"Steve Jobs", "+18143008203"},
                {"Bill Gates", "+14842634807"},
                {"Mark Zuckerberg", "+18143008198"},
                {"Bill Gates", "+16102458208"},
                {"Walt Disney", "+14842989001"}
            };
            
            // Two dimensional array which will be populated from two arrays
            var phoneBook = new string[Rows, Columns];
            
            var names = new string[] {"Steve Jobs", "Bill Gates", "Mark Zuckerberg", "Jeff Bezos", "Walt Disney"};
            var phoneNumbers = new string[]
                {"+18143008203", "+14842634807", "+18143008198", "+16102458208", "+14842989001"};

            for (int i = 0; i < phoneBook.GetLength(0); i++)
            {
                for (int j = 0; j < phoneBook.GetLength(1); j++)
                {
                    if (j == 0)
                    {
                        phoneBook[i, j] = names[i];
                        continue;
                    }

                    phoneBook[i, j] = phoneNumbers[i];
                }
            }

            Console.WriteLine("Hardcoded two dimensional array");
            Console.WriteLine("---------------------------------");
            PrintMatrix(example);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Two dimensional array populated from other arrays");
            Console.WriteLine("---------------------------------");
            PrintMatrix(phoneBook);
        }

        static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }
        }
    }
}