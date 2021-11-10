namespace Lesson8
{
    public class Room
    {
        private Printer _printer;

        public void MakeThisLazyPrinterWork(string value)
        {
            _printer.Print(value);
        }

        public void ReplacePrinter(Printer printer)
        {
            _printer = printer;
        }
    }
}