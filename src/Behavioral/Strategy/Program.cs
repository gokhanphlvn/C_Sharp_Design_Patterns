// See https://aka.ms/new-console-template for more information
using Strategy;

Console.Title = ("Strategy Pattern");

var order = new Order("Gökhan Software", 5, "VS License", new CSVExportService());
order.Export();
order.ExportService = new JsonExportService();
order.Export();
order.Export(new XMLExportService());

Console.ReadKey();
