using System;
using AverageTemperature.model;

namespace AverageTemperature
{
    enum State
    {
        MinTemp,
        MaxTemp,
        CheckMaxTemp,
        WrongMaxTemp,
        WrongCharacter,
        Continue,
        CalculateAverage,
        Quit
    }

    enum TempState
    {
        Min,
        Max,
        None
    }

    class Program
    {
        static void Main(string[] args)
        {
            var state = State.MinTemp;
            var tempState = TempState.None;
            var print = new Print();

            int? minTemp = null;
            int? maxTemp = null;
            string userInput;
            
            while (true)
            {
                switch (state)
                {
                    case State.MinTemp:
                        HandleMinTempState();
                        break;
                    
                    case State.MaxTemp:
                        HandleMaxTemperature();
                        break;
                    
                    case State.CheckMaxTemp:
                        CheckMaxTemp();
                        break;
                    
                    case State.WrongMaxTemp:
                        HandleWrongMaxTemp();
                        break;
                    
                    case State.WrongCharacter:
                        HandleWrongChar();
                        break;
                    
                    case State.Continue:
                        HandleContinue();
                        break;
                    
                    case State.CalculateAverage:
                        HandleAverage();
                        break;
                    
                    case State.Quit:
                        return;
                }
            }

            void HandleMinTempState()
            {
                print.ShowTemperatureMessage(TemperatureType.Minimum);
                userInput = Console.ReadLine();
                tempState = TempState.Min;
                if (Int32.TryParse(userInput, out int i))
                {
                    minTemp = i;
                    state = State.MaxTemp;
                }
                else
                {
                    state = State.WrongCharacter;
                }
            }

            void HandleMaxTemperature()
            {
                print.ShowTemperatureMessage(TemperatureType.Maximum);
                userInput = Console.ReadLine();
                tempState = TempState.Max;
                if (Int32.TryParse(userInput, out int j))
                {
                    maxTemp = j;
                    if (minTemp > j)
                    {
                        state = State.WrongMaxTemp;
                        return;
                    }
                    state = State.CalculateAverage;
                }
                else
                {
                    state = State.WrongCharacter;
                }
            }

            void HandleWrongMaxTemp()
            {
                if (!minTemp.HasValue)
                {
                    state = State.Quit;
                    return;
                }
                
                print.ShowWrongMaxTemperature(minTemp.Value);
                userInput = Console.ReadLine();
                
                if (userInput == "y" || userInput == "Y")
                {
                    state = State.MaxTemp;
                }
                else if (userInput == "n" || userInput == "N")
                {
                    state = State.Quit;
                }
                else
                {
                    state = State.WrongCharacter;
                }
            }

            void CheckMaxTemp()
            {
                if (!minTemp.HasValue || !maxTemp.HasValue)
                {
                    state = State.Quit;
                    return;
                }

                if (minTemp.Value > maxTemp.Value)
                {
                    state = State.WrongMaxTemp;
                }
            }

            void HandleWrongChar()
            {
                Console.WriteLine("wrong input. Try again? Y/N");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "Y")
                {
                    state = State.Continue;
                }
                else if (userInput == "n" || userInput == "N")
                {
                    state = State.Quit;
                }
                else
                {
                    state = State.WrongCharacter;
                }
            }

            void HandleContinue()
            {
                switch (tempState)
                {
                    case TempState.Min: state = State.MinTemp;
                        break;
                    case TempState.Max: state = State.MaxTemp;
                        break;
                    case TempState.None: state = State.Quit;
                        break;
                }
            }

            void HandleAverage()
            {
                if (minTemp.HasValue && maxTemp.HasValue)
                {
                    var averageCalculator = new AverageCalculator(new int[] {minTemp.Value, maxTemp.Value});
                    double average = averageCalculator.CalculatedAverage();
                    print.ShowCalculateTemperatureAverageMessage(average);
                }
                        
                state = State.Quit;
            }
        }
    }
}
