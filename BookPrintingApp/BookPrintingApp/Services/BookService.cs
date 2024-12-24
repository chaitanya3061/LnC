using BookPrintingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BookPrintingApp.Services
{
    public class BookService
    {
        public void turnPage()
        {
            Console.WriteLine("Turning page..");
        }

        public void save(Book book)
        {
            string filename = Path.Combine("/docs", $"{book.Title} - {book.Author}.txt");
            File.WriteAllText(filename, this.ToString());
        }

        public void getCurrentPage()
        {
            Console.WriteLine( "current page content");
        }
    }
}
