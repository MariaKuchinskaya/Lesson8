using System;

namespace Lesson8
{
    public class GreenPrinter: Printer
    {
        public override void Print(string a)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(a);
            Console.ResetColor();
        }
    }
}