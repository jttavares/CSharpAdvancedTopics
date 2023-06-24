﻿// See https://aka.ms/new-console-template for more information
using _06_Generics;

Console.WriteLine("Hello, World!");
var book = new Book { Isbn = "1111", Title = "C# Advanced" };


//var numbers = new List();
//numbers.Add(10);

//var books = new BookList();
//books.Add(book);

var numbers = new GenericList<int>();
numbers.Add(10);

var books = new GenericList<Book>();
books.Add(book);

var dictionary = new GenericDictionary<string, Book>();
dictionary.Add("1234", book);

var number = new _06_Generics.Nullable<int>(5);
Console.WriteLine("Has Value? "+number.HasValue);
Console.WriteLine("Value: "+number.GetValueOrDefault());