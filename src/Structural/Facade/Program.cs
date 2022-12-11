// See https://aka.ms/new-console-template for more information
using Facade;

Console.Title = ("Facade Pattern");

var facade = new DiscountFacade();

Console.WriteLine($"Discoutn percentage for customer with id 1: {facade.CalculateDiscountPercantege(1)}");
Console.WriteLine($"Discoutn percentage for customer with id 10: {facade.CalculateDiscountPercantege(10)}");

Console.ReadLine();
