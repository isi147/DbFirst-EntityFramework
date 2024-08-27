

using ConsoleApp22.Context;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp22
{
    public class BookService
    {
 
        private readonly LibraryContext _context;

        public BookService(LibraryContext context)
        {
            _context = context;
        }

        public void GetAllBooks()
        {
            if (_context == null)
            {
                Console.WriteLine("DbContext is not initialized.");
                return;
            }

            var books = _context.Books.Select(x => new { x.Id, x.Name }).ToList();

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Id}: {book.Name}");
            }
        }


    }
}
