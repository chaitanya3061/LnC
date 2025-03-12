using BookPrintingApp.Services.Interfaces;

namespace BookPrintingApp.Services
{
    public class HtmlPrinter : IPrinter
    {
        public void printPage(string page)
        {
            Console.WriteLine($"<div style=\"single-page\">{page}</div>");
        }
    }
}
