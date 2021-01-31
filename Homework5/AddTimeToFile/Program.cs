using System;
using System.IO;

namespace AddTimeToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = DateTime.Now;
            var timeFormat = "dd/MM/yyyy HH:mm:ss";
            var timeString = time.ToString(timeFormat);
            
            File.AppendAllLines("startup.txt", new [] {timeString});
        }
    }
}