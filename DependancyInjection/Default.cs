using System;

namespace DependancyInjection
{
    public class Default : IPrint
    {
        public void Print(string Data)
        {
            Console.WriteLine(Data);
        }
    }
    public class ColorPrint : IPrint
    {
        public void Print(string Data)
        {
            Console.BackgroundColor = consoleColor;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Data);
        }
        public ConsoleColor consoleColor;
        public ColorPrint(ConsoleColor color)
        {
           this.consoleColor = color;
        }
    }
}
