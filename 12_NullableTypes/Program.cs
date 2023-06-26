// See https://aka.ms/new-console-template for more information
//DateTime? date = null;
DateTime? date = new DateTime(2023, 06, 26);


Console.WriteLine("GetvalueOrDefault "+date.GetValueOrDefault()); ;
Console.WriteLine("HasValue: "+date.HasValue);
Console.WriteLine("Value: "+date.Value);

Console.WriteLine("\ndate2\n");
var date2 = date.GetValueOrDefault();
Console.WriteLine(date2);


Console.WriteLine("\ndate3\n");
DateTime? date3 = date2;
Console.WriteLine("GetvalueOrDefault "+date3.GetValueOrDefault()); ;
Console.WriteLine("HasValue: "+date3.HasValue);
Console.WriteLine("Value: "+date3.Value);


//NullCoallescing Operator
DateTime? date4 = null;
DateTime date5 = date ?? DateTime.Today;
/*
if (date4 != null)
    date5 = date4.GetValueOrDefault();
else
    date5 = DateTime.Today;
*/
Console.WriteLine("\ndate5: => "+date5);