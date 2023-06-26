// See https://aka.ms/new-console-template for more information
using _06_Generics;
using _08_LambdaExpressions;

Console.WriteLine("Hello, World!");
Console.WriteLine(Square(5));
Func<int, int> square = Square;
Console.WriteLine("square => " + square(10));

const int factor = 5;

Func<int, int> muliplier = n => n * factor;
Console.WriteLine("multiplier => " + muliplier(10));
var books = new BooksRepository().GetBooks();
var cheapBooks = books.FindAll(book => book.Price < 10);
foreach (var item in cheapBooks)
{
    Console.WriteLine(item.ToString());
}

//an anonymous method
//no access modifier
//no name
//no return statement
//why to use
//for convenience
static int Square(int number) => number * number;
