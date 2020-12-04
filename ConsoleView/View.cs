using System;
using System.Collections.Generic;
using System.Text;
using ViewInterface;

namespace ConsoleView
{
    class View : ICounterView
    {
        public void SetNumber(String value)
        {
            Console.WriteLine(value);
            Console.WriteLine();
        }

        public void PrintMenu(string text)
        {

            Console.WriteLine(text);
            Console.WriteLine();

        }

        public string ReadCommand()
        {
            string command = Console.ReadLine();
            command = command.ToLower();
            return command;
        }

        public void NoSuchCommand()
        {
            Console.WriteLine("No such command." + Environment.NewLine);
        }
    }
}
