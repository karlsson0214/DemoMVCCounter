using System;
using System.Collections.Generic;
using System.Text;
using CounterModel;

namespace ConsoleView
{
    class Controller
    {
        private View view = new View();
        private Counter model = new Counter();
        private string menuText;
        private bool isRunning = true;

        public Controller()
        {
            menuText = "Select an alternative:" + Environment.NewLine + 
                "i - increase" + Environment.NewLine + 
                "d - decrease" + Environment.NewLine + 
                "r - reset" + Environment.NewLine +
                "m - reset to max";
            while (isRunning)
            {
                Run();
            }
        }

        private void Run()
        {
            string number = model.GetValue();
            view.SetNumber(number);
            view.PrintMenu(menuText);
            string command = view.ReadCommand();
            if (command == "i")
            {
                model.Increase();
            }
            else if (command == "d")
            {
                model.Decrease();
            }
            else if (command == "r")
            {
                model.Reset();
            }
            else if (command == "m")
            {
                model.ResetToMax();
            }
            else
            {
                // no such command
                view.NoSuchCommand();
            }

        }

    }
}
