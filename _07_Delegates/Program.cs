// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//an object that knoes how to call a method
//a reference to a function
//for design extensible and flexible applications

//Interfaces or Delegate
//Use a delegate when
    //An eventing design pattern is used
    //The caller doesn't need to access other prperties or methods on the object impelemnting th method

var photoProcessor = new PhotoProcessor();
var filters = new PhotoFilters();
//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
Action<Photo> filterHandler = filters.ApplyBrightness;
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilter;

photoProcessor.Process("photo.jpg", filterHandler);

static void RemoveRedEyeFilter(Photo photo) => Console.WriteLine("RemovedRedEye");
