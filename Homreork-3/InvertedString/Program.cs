using System;
using System.Linq;
using System.Text;

namespace InvertedString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var userInput = Console.ReadLine();
            Console.WriteLine($"Inverted text {userInput}: [ {InvertString(userInput)} ]");
        }

        static string InvertString(string text)
        {
            var resultStringBuilder = new StringBuilder();
            
            for (int i = text.Length - 1; i >= 0; i--)
            {
                resultStringBuilder.Append(text[i]);
            }
            return resultStringBuilder.ToString();
        }
    }
}