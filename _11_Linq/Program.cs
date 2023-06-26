// See https://aka.ms/new-console-template for more information



using Shared;

var books = new BooksRepository().GetBooks();
//LINQ Query Operators
var cheaperBooks = from book in books
                   where book.Price < 10
                   orderby book.Title
                   select book.Title;
//LINQ Extension Methods
var cheapBooks = books
                    .Where(book => book.Price < 10)
                    .OrderBy(book => book.Title)
                    .Select(book => book.Title).ToList();
//PrintBooks(cheapBooks);
Console.WriteLine("\nBooks\n");
books.Print<Book>();

Console.WriteLine("\nCheapBooks\n");
cheaperBooks.PrintStrings();

Console.WriteLine("\nCheaperBooks\n");
cheaperBooks.PrintStrings();

Console.WriteLine("\n\n");

var single = books.Single(book => book.Title == "ASP.NET MVC");
Console.WriteLine("Single => "+single.ToString());

var first = books.First(book=> book.Title == "C# Advanced Topics");
Console.WriteLine("first => "+first.ToString());

var last = books.Last(book=> book.Title == "C# Advanced Topics");
Console.WriteLine("last => "+last.ToString());

var pagedBook = books.Skip(2).Take(3);
Console.WriteLine("\nPagedBooks =>");
pagedBook.Print();

Console.WriteLine("\nCount =>");
var count = books.Count();
count.Print();

Console.WriteLine("\nMaxPrice");
var maxPrice = books.Max(book => book.Price);
Console.WriteLine(maxPrice.ToString());

Console.WriteLine("\nminPrice");
var minPrice = books.Min(book => book.Price);
Console.WriteLine(minPrice.ToString());


Console.WriteLine("\ntotalPrice");
var totalPrice = books.Sum(book => book.Price);
Console.WriteLine(totalPrice.ToString());

Console.WriteLine("\naverage");
var average = books.Average(book => book.Price);
Console.WriteLine(average.ToString());



//Stands for: Language Integrated Query
//Gives you the capability to query Objects
//you can query
    //objects in memory, eg collections (LINQ to Objects)
    //Databases (Linq to Entities)
    //XML (LINQ to XML)
    //ADO.NET Data Sets (LINQ TO Data Sets)

