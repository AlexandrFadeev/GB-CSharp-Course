using System;
using System.Linq;
using System.Text;

namespace InvertedString
{
    class Program
    {
        private const string Text = "Hello";
        static void Main(string[] args)
        {
            Console.WriteLine($"Inverted text Hello: [ {InvertString(Text)} ]");
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