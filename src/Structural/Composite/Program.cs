// See https://aka.ms/new-console-template for more information
Console.Title = ("Composite Pattern");
var root = new Composite.Directory("root", 0);
var toplevel = new Composite.File("toplevel.txt", 100);
var toplevelDirectory1 = new Composite.Directory("toplevelDirectory1", 4);
var toplevelDirectory2 = new Composite.Directory("toplevelDirectory2", 4);
root.Add(toplevel);
root.Add(toplevelDirectory1);
root.Add(toplevelDirectory2);
var sublevelDirectory1 = new Composite.Directory("sublevelDirectory1", 200);
var sublevelDirectory2 = new Composite.Directory("sublevelDirectory2", 150);
toplevelDirectory2.Add(sublevelDirectory1);
toplevelDirectory2.Add(sublevelDirectory2);
Console.WriteLine($"Size of toplevelDirectory1: {toplevelDirectory1.GetSize()}");
Console.WriteLine($"Size of toplevelDirectory2: {toplevelDirectory2.GetSize()}");
Console.WriteLine($"Size of root: {root.GetSize()}");

Console.ReadKey();