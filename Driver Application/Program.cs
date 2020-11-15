using DependancyInjection;
using System;

namespace Driver_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set Theme");
            Console.WriteLine("1: Default \n 2: Blue&White \n  Choose Your Theme :");
            var themeOption = Convert.ToInt32(Console.ReadLine());

            Default objDefault = new Default();
            Display display = new Display(objDefault);
            switch (themeOption)
            {
                case 2:
                    ColorPrint objColorPrint = new ColorPrint(ConsoleColor.Blue);
                    display = new Display(objColorPrint);
                    break;
            }

            display.PrintToConsole("HelloWorld");
            Console.ReadLine();
        }
    }
    class Display
    {
        private IPrint _print;
        public Display(IPrint print)
        {
            _print = print;
        }

        public void PrintToConsole(string Data)
        {
            _print.Print(Data);
        }
    }
   
}
