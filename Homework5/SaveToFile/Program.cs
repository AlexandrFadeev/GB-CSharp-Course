using System;
using System.IO;

namespace SaveToFile
{
    class Program
    {
        private const string FileName = "temp.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text:");
            File.WriteAllText(FileName, Console.ReadLine());
        }
    }
}