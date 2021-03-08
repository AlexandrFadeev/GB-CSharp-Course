using System;
using System.Collections.Generic;

namespace Algorithms4
{
    public class StringCollectionGenerator
    {
        private Random _random = new Random();
        
        public List<string> GenerateStringsArray(int arrayLenght)
        {
            var wordLenght = 8;
            var tempString = "";
            var list = new List<string>();
            
            for (var i = 0; i < arrayLenght; i++)
            {
                for (var j = 0; j < wordLenght; j++)
                {
                    tempString += ((char) (_random.Next(1, 26) + 64)).ToString().ToLower();
                }
                list.Add(tempString);
                tempString = "";
            }
            
            return list;
        }
    }
}