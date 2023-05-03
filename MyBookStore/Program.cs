using Microsoft.EntityFrameworkCore;
using MyBookStore.Data;
using MyBookStore.Model;

namespace MyBookStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Skapa context objektet
            BookContext context = new BookContext();

            string authorName = "Tolkien";

            //Hämta books från DB
            //List<Book> booksAvTolkien = context.Book.Where(m => m.Author.Name == authorName).ToList();
            /*
            //Hämta data från DB, med både BOoks och Athors
            List<Book> booksAvTolkien = context.Book.Include(n => n.Author).Where(m => m.Author.Name == authorName).ToList();

            foreach (Book book in booksAvTolkien)
                Console.WriteLine("Booken {0} är skriven av {1}", book.Title, book.Author.Name);
            */
            //Hämta specifk book med info om författare samt alla böcker som författaren har skrivit.
            string bookTitle = "Hobbit";

            Book hobbitBook = context.Book.Include(m => m.Author).ThenInclude(n => n.Books).Where(o => o.Title == bookTitle).FirstOrDefault();

            foreach(Book book in hobbitBook.Author.Books)
            {
                Console.WriteLine("{0} {1}", book.Title, book.Author.Name);
            }


        }

        static void GetBooks(BookContext context)
        {
            //Hämta alla böcker och skriv ut dem i en lista
            List<Book> books = context.Book.ToList();
            List<Author> author = context.Author.ToList();

            //Hämta böcker billaigare än 300
            List<Book> cheapBooks = context.Book.Where(m => m.Price < 300).ToList();

            //Skriv ut titlar på alla böcker
            foreach (Book book in books)
            {
                Console.WriteLine("Booken heter: {0}", book.Title);
            }

            //Skriv ut titlar på alla billiga böcker
            foreach (Book book in cheapBooks)
            {
                Console.WriteLine("Booken heter: {0}. Den är en billig bok med priset {1}", book.Title, book.Price);
            }
        }

        static void AddNewBook(BookContext context)
        {
            //Lägga till en ny bok
            Book newBook = new Book()
            {
                Title = "Hercule Poirot",
                Price = 349
            };

            //Lägg till ny book till tabell
            context.Book.Add(newBook);

            //Spara ändringar
            context.SaveChanges();
        }
    }
}