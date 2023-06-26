using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class BooksRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
               new Book(){Title = "ADO.NET Step By Step", Price = 5, Isbn = "1234"},
                new Book(){Title = "ASP.NET MVC", Price = 9.99F, Isbn = "4567"},
                new Book(){Title = "ASP.NET Web API", Price = 12, Isbn = "7890"},
                new Book(){Title = "C# Advanced Topics", Price = 7, Isbn = "2222"},
                new Book(){Title = "C# Advanced Topics", Price = 9, Isbn = "3333"},
            };
        }
    }
}
