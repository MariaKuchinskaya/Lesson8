using System;

namespace Lesson8
{
    class Program
    {
        static void Main()
        {
            var printers = new Printer[]
            {
                new BluePrinter(),
                new GreenPrinter()
            };

            var room = new Room();

            foreach (var printer in printers)
            {
                room.ReplacePrinter(printer);
                room.MakeThisLazyPrinterWork(Console.ReadLine());
            }
        }
    }
}
