using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace BinarySerializator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter sequence of numbers");
            var userInput = Console.ReadLine();

            var formatter = new BinaryFormatter();
            var fileStream = new FileStream("numbers.bin", FileMode.OpenOrCreate);
            formatter.Serialize(fileStream, userInput ?? throw new InvalidOperationException());
        }
    }
}