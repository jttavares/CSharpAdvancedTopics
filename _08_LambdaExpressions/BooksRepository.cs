using _06_Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_LambdaExpressions
{
    public class BooksRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(){Title = "Title 1", Price = 5, Isbn = "1234"},
                new Book(){Title = "Title 2", Price = 7, Isbn = "4567"},
                new Book(){Title = "Title 3", Price = 17, Isbn = "7890"},
            };
        }
    }
}
