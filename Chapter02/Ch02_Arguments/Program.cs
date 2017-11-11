using System;
using static System.Console;

namespace Ch02_Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);
                BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);
                WindowWidth = int.Parse(args[2]);
                WindowHeight = int.Parse(args[3]);
            }
            catch (IndexOutOfRangeException e) {
                WriteLine("One or more arguments are missing!");
                WriteLine($"Stacktrace: {e}");
            }
            // Handling platforms that do not support an API
            // WindowWidth, WindowHeight
            catch (PlatformNotSupportedException) {
                WriteLine("The current platform doe not support chaning the size of a console window.");
            }
            
            DisplayArguments(args);
        }

        // Enumerating agurments
        private static void DisplayArguments(string[] args) {
            WriteLine($"There are {args.Length} arguments.");
            foreach (var arg in args)
            {
                WriteLine($"Arguments are {arg}");
            }
        }
    }
}