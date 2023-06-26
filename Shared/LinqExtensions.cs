using System.Collections.Generic;
using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;

namespace System.Linq
{
    public static class LinqExtensions
    {
        public static void PrintStrings(this IEnumerable<String>? textos)
        {
            if(textos == null)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach (var texto in textos)
                {
                    Console.WriteLine(texto);

                }

            }
        }

        public static void Print<TSource>(this IEnumerable<TSource> collection) {
            if (collection == null)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.ToString());

                }

            }
        }
        
        public static void Print<TSource>(this IList<TSource> collection) {
            if (collection == null)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach (var item in collection)
                {
                    Console.WriteLine(item.ToString());

                }

            }
        }

        public static void Print(this Int32 number)
        {
            Console.WriteLine(number);
        }

        
    }

}
