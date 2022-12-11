// See https://aka.ms/new-console-template for more information
using FactoryMethod.Implementations;

Console.Title = ("Factory Method Pattern");

var factories = new List<DiscountFactory> {
    new CountryDiscountFactory("TR"), 
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("US") 
};
foreach (var factory in factories)
{
    var discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage {discountService.DiscountPercentage} comming from {discountService}");
}
Console.ReadLine();
