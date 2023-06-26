// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Allow us to add methods to an exisiting class without
//changing its source code
//creating a new class that inherits from it

string post = "This is a supposeed to be a very long blog post blah blah blah...";
var shortenedPost = post.Shorten(5);
Console.WriteLine(shortenedPost.ToString());

IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 };
int max = numbers.Max();
Console.WriteLine("Max => "+max);

