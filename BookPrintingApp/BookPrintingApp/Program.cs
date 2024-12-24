using BookPrintingApp.Models;
using BookPrintingApp.Services;
using BookPrintingApp.Services.Interfaces;

namespace BookPrintingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Clean Code", "Robert Cecil Martin");
            BookService bookService = new BookService();

            BookLocation location = new BookLocation("A101", "Room 104");
            Console.WriteLine($"Book Location: {location.getLocation()}");

            IPrinter plainTextPrinter = new PlainTextPrinter();
            plainTextPrinter.printPage(book.ToString());

            IPrinter htmlPrinter = new HtmlPrinter();
            htmlPrinter.printPage(book.ToString());

            bookService.save(book);
        }
    }
}
