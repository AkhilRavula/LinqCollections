using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var books = BooksRepo.GetBooks();


            var cheaperbooks = from b in books
                               where b.Price >10
                               orderby b.Price descending
                               select b.Name;

            //Linq Extension Methods
            var CheapBooks = books
                                 .Where(x => x.Price > 10)
                                 .OrderByDescending(x => x.Price)
                                 .Select(x => x.Name).ToList();

            var book1 = books.SingleOrDefault(b=>b.Price == 11);

            var book2 = books.FirstOrDefault(b=>b.Price == 12);

            var book3 = books.LastOrDefault(b=>b.Price == 13);

            var book4 = books.Skip(2).Take(1).ToList();

            Console.WriteLine(book2.Name);


            var CountBooks = books.Count();
            Console.WriteLine(CountBooks);

            var BookMax = books.Max(b => b.Price);
            Console.WriteLine(BookMax);

            var BookMin = books.Min(b => b.Price);
            Console.WriteLine(BookMin);

            Console.WriteLine(book1+"---");
         //   Console.WriteLine(book1.Name+"---");



            foreach (var book in cheaperbooks)
            {
                Console.WriteLine(book);
            }

            foreach (var book in CheapBooks)
            {
                Console.WriteLine(book);
            }
        }
    }
}
