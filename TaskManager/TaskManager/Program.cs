using System;
using System.Diagnostics;
using System.Linq;

namespace TaskManager
{
    public enum TaskKillType
    {
        Id,
        Name
    }

    class Program
    {
        private const string HelpKeyword = "help";
        private const string ProcessesListKeyword = "list";
        private const string ProcessKillKeyword = "kill";

        private const string KillByIdFlagKeyword = "-id";
        private const string KillByNameFlagKeyword = "-name";

        static void Main(string[] args)
        {
            Program program = new Program();

            while(true)
            {
                var userInput = Console.ReadLine();
                switch (userInput)
                {
                        // Help
                    case HelpKeyword: program.PrintHelp();
                        break;

                        // List
                    case ProcessesListKeyword: program.PrintProccesses();
                        break;

                        // Kill
                    case string _ when userInput.StartsWith(ProcessKillKeyword):
                        program.HandleKillCommand(userInput);
                        break;

                        // Command Not Found
                    default:
                        program.PrintCommandNotFound(userInput);
                        break;
                }
            }
        }

        private void PrintProccesses()
        {
            Process[] processes = Process.GetProcesses();

            SortProcessesAlphabetically(processes);

            foreach (Process process in processes)
            {
                Console.WriteLine($"Id: {process.Id} | Name: {process.ProcessName}");
            }

            PrintLine();
        }

        private void HandleKillCommand(string userInput)
        {
            try
            {
                var arguments = KillCommandArguments(userInput);
                ParseKillCommand(arguments);
            }
            catch (TaskManagerException exception) when (exception.Code == ErrorCode.MissingArgument)
            {
                Console.WriteLine($"Missing argument. { KillCommantArgumentHelpText() }");
            }
            catch (TaskManagerException exception) when (exception.Code == ErrorCode.MissingValue)
            {
                Console.WriteLine($"Missing command value. { KillCommantArgumentHelpText() }");
            }
            catch (TaskManagerException exception) when (exception.Code == ErrorCode.WrongArgumentNumber)
            {
                Console.WriteLine($"Wrong argument number. { KillCommantArgumentHelpText() }");
            }
        }

        private string[] KillCommandArguments(string userInput)
        {
            var components = userInput.Split(' ');
            // skip 'kill' word
            components = components.Skip(1).ToArray();

            switch (components.Length)
            {
                case 0: throw new TaskManagerException(ErrorCode.MissingArgument);
                case 1: throw new TaskManagerException(ErrorCode.MissingValue);
                case 2: return components;
                default: throw new TaskManagerException(ErrorCode.WrongArgumentNumber);
            }
        }

        private void ParseKillCommand(string[] arguments)
        {
            try
            {
                var argument = ParseKillTaskArgument(arguments.First());
                if (argument == TaskKillType.Id)
                {
                    try
                    {
                        var proccessId = Convert.ToInt32(arguments.Last());
                        KillProcessById(proccessId);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error! Process id must be numeric value");
                        return;
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Error!. Proccess id number overflow. Please try again");
                    }
                } 
                else
                {
                    KillProcessByName(arguments.Last());
                }

            }
            catch (TaskManagerException exception) when (exception.Code == ErrorCode.WrongArgument)
            {
                Console.WriteLine($"'{arguments.First()}' wrong argument. { KillCommantArgumentHelpText() }");
            }
        }

        private TaskKillType ParseKillTaskArgument(string argument)
        {
            switch (argument)
            {
                case KillByIdFlagKeyword: return TaskKillType.Id;
                case KillByNameFlagKeyword: return TaskKillType.Name;
                default: throw new TaskManagerException(ErrorCode.WrongArgument);
            }
        }

        private void KillProcessById(int processId)
        {
            try
            {
                Process process = Process.GetProcessById(processId);
                process.Kill();
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"Error! Process with id {processId} does not exist");
            }
        }

        private void KillProcessByName(string proccessName)
        {
            Process[] processes = Process.GetProcessesByName(proccessName);
            if (processes.Length == 0)
            {
                Console.WriteLine($"Procces with name '{proccessName}' does not exist");
                return;
            }

            foreach (Process process in processes)
            {
                process.Kill();
            }
        }

        private void PrintHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine("=======================================");
            Console.WriteLine("list: Prints list of all processes");
            Console.WriteLine($"kill {KillByIdFlagKeyword} <PID>: Kills process by given id");
            Console.WriteLine($"     {KillByNameFlagKeyword} <Process name>: Kills all processes by given name");
            PrintLine();
        }

        private string KillCommantArgumentHelpText()
        {
            return $"Please type {HelpKeyword} to check valid command arguments";
        }

        private void PrintCommandNotFound(string inputCommand)
        {
            Console.WriteLine($"'{inputCommand}' command not found. Please type {HelpKeyword} to check available commands");
            PrintLine();
        }

        private void PrintLine()
        {
            Console.WriteLine("--------------------------------------\n");
        }

        private void SortProcessesAlphabetically(Process[] processes)
        {
            Array.Sort(processes, (x, y) => String.Compare(x.ProcessName, y.ProcessName));
        }
    }
}
