// See https://aka.ms/new-console-template for more information
using Builder;

Console.Title = "Builder Pattern";
var garage = new Garage();
var audiBuilder = new AudiBuilder();
garage.Construct(audiBuilder);
Console.WriteLine(audiBuilder.Car.ToString());
garage.Show();
var bmwBuilder = new BmwBuilder();
garage.Construct(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());
garage.Show();
Console.ReadKey();
