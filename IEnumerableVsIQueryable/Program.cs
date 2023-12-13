using IEnumerableVsIQueryable;
using Microsoft.EntityFrameworkCore;

namespace IEnumerableVsIQueryable
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookDemoDbContext())
            {

                var booksIEnumerable = (from book in context.Books
                                        select book)
                                        .AsEnumerable<Book>().Take(2).ToList();


                var booksIQurable = (from book in context.Books
                                     select book)
                                     .AsQueryable<Book>().Take(2).ToList();
            }

            Console.ReadKey();
        }
    }
}