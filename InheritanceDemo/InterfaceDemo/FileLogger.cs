using System;

namespace InterfaceDemo
{
    public class FileLogger : ILogger
    {
        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine(message);
        }

        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            System.Console.WriteLine(message);
        }
    }
}
