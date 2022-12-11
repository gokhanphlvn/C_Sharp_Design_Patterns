// See https://aka.ms/new-console-template for more information
using Singleton;

Console.Title = ("Singleton pattern!");

var instance_1 = Logger.Instance;
var instance_2 = Logger.Instance;

if (instance_1==instance_2 && instance_2==Logger.Instance)
{
    Console.WriteLine("Instance are the same");
}
else
{
    Console.WriteLine("Instance are different");
}

instance_1.Log("instance_1");
instance_1.Log("instance_2");
Console.ReadLine();
