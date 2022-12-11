// See https://aka.ms/new-console-template for more information
using AbstractFactory.Implementations;

Console.Title = "Abstract Factory";

var turkiyeShippingCartPurchaseFactory = new TurkiyeShippingCartPurchaseFactory();
var shoppingCartForTurkiye = new ShoppingCart(turkiyeShippingCartPurchaseFactory);
shoppingCartForTurkiye.CalculateCosts();

var azerbaycanShippingCartPurchaseFactory = new AzerbaycanShippingCartPurchaseFactory();
var shoppingCartForAzerbaycan = new ShoppingCart(azerbaycanShippingCartPurchaseFactory);
shoppingCartForAzerbaycan.CalculateCosts();

Console.ReadKey();