using ConsoleApp22.Context;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LibraryContext libraryContext = new LibraryContext();

            BookService bookService = new BookService(libraryContext);

            bookService.GetAllBooks();
        }
    }
}
