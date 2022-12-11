// See https://aka.ms/new-console-template for more information
using Bridge;

Console.Title = ("Bridge Pattern");


var noCoupon = new NoCoupon();

var oneUsdCoupon = new OneUSDCoupon();

var meatBasedMenu = new MeatBasedMenu(noCoupon);

Console.WriteLine($"Meat base menu, no coupon {meatBasedMenu.CalculatePrice()} usd.");

meatBasedMenu = new MeatBasedMenu(oneUsdCoupon);

Console.WriteLine($"Meat base menu, one coupon {meatBasedMenu.CalculatePrice()} usd.");


var vegetarianMenu = new VegetarianMenu(noCoupon);

Console.WriteLine($"Vegetarian menu, no coupon {vegetarianMenu.CalculatePrice()} usd.");

vegetarianMenu = new VegetarianMenu(oneUsdCoupon);

Console.WriteLine($"Vegetarian menu, one coupon {vegetarianMenu.CalculatePrice()} usd.");



Console.ReadKey();