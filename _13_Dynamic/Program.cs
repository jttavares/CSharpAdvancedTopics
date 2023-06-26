// See https://aka.ms/new-console-template for more information
//Programing languages
//Statically typed langauges: C#, Java
//dynamic-typed languages: Ruby, Javascript, Python
//Type resolution
//static languages: at compile-time
//dynamic languages: at run-time
//Benefits
//static languages: early feedback (compile-time)
//dynamic languages: easier anf faster to code
//C# History
//started as a static language
//.NET4 added the dynamic capability, to improve interoperability with
//COM (eg writting office applications)
//word, excel
//dynamic language (IronPython)

/*
object obj = "Mosh";
var methodInfo = obj.GetType().GetMethod("GetHasCode");

dynamic excelObject = "mosh";
excelObject.Optimize();
*/

dynamic a = 1;
dynamic b = 5;
var c = a + b;
Console.WriteLine(c);

int i = 5;
dynamic d = i;
Console.WriteLine(d);

long l = d;
Console.WriteLine(l);