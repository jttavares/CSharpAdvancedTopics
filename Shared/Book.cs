using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    public class Book:Product
    {
        public string Isbn { get; set; }

        public override string ToString()
        {
            return $"{Title}, Price: {Price}, Isbn = {Isbn}";
        }

        public void Print() => this.ToString();
    }
}
