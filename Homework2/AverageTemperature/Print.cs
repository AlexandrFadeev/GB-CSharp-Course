using System;

namespace AverageTemperature
{
    public class Print
    {
        // Public methods
        // ------------------------------------------------------------------------
        public void DrawLine()
        {
            Console.WriteLine("--------------------------------------------------------");
        }

        public void ShowInvalidInputMessage()
        {
            Console.WriteLine("Invalid input. Please enter Integer number. Try again? Y/N");
        }
        
        public void ShowTemperatureMessage(TemperatureType temperatureType)
        {
            string temperatureTypeString = "";

            switch (temperatureType)
            {
                case TemperatureType.Minimum: temperatureTypeString = "minimum";
                    break;
                case TemperatureType.Maximum: temperatureTypeString = "maximum";
                    break;
            }
            
            Console.WriteLine($"Enter {temperatureTypeString} temperature. (Integer number)");
        }

        public void ShowCalculateTemperatureAverageMessage(double average)
        {
            Console.WriteLine($"Average temperature is {average} degrees");
        }

        public void ShowWrongMaxTemperature(int minTemperature)
        {
            Console.WriteLine($"Maximum temperature must be higher or equal of {minTemperature}");
        }

        public void ShowChooseMonthMessage()
        {
            Console.WriteLine("Please enter number of moth. Available range is from 1 to 12");
        }
    }
}