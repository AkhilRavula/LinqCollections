using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqCollections
{
    internal class BooksRepo
    {

        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() { Name = "AKIL",Price =12},
                new Book() { Name ="BUIO",Price =15},
                new Book() { Name ="wty",Price=9}
            };
        }
    }
}
