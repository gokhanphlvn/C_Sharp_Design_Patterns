// See https://aka.ms/new-console-template for more information
using Adapter;
using object_Adapter = Adapter.Object_Adapter_Implementation;
using class_Adapter = Adapter.Class_Adapter_Implementation;

Console.Title = ("Adapter Pattern");

object_Adapter.ICityAdapter adapter = new object_Adapter.CityAdapter();
var city = adapter.GetCity();
Console.WriteLine($"{city.FullName}, {city.Inhabitants}");

class_Adapter.ICityAdapter adapter_Class = new class_Adapter.CityAdapter();
var city_Class = adapter_Class.GetCity();
Console.WriteLine($"{city_Class.FullName}, {city_Class.Inhabitants}");
Console.ReadKey();
