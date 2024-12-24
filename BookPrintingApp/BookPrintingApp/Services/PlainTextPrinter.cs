using BookPrintingApp.Services.Interfaces;

namespace BookPrintingApp.Services
{
    public class PlainTextPrinter : IPrinter
    {
        public void printPage(string page)
        {
            Console.WriteLine(page);
        }
    }
}
