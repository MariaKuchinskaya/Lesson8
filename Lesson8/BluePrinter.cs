using System;

namespace Lesson8
{
    public class BluePrinter: Printer
    {
        public override void Print(string a)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}