using System;
using AltusProgrammerTest.Core.Interfaces;

namespace AltusProgrammerTest.Core.Services
{
    public class ConsoleService : IConsoleService
    {
        public void OutputErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void OutputMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(message);
        }

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
