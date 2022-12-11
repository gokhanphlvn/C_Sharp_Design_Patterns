// See https://aka.ms/new-console-template for more information
Console.Title = ("Proxy Pattern");

//with Proxy
Console.WriteLine("Constructing document");
var myDocument = new Proxy.Document("MyDocument.pdf");
Console.WriteLine("Document constructed");
myDocument.DisplayDocument();

Console.WriteLine();

//with proxy
Console.WriteLine("Constructing document proxy");
var myDocumentProxy = new Proxy.DocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

//with chained proxy
Console.WriteLine("Constructing protected document proxy");
var myProctectedDocumentProxy = new Proxy.ProtectedDocumentProxy("MyDocument.pdf","Viewer");
Console.WriteLine("Protected Document proxy constructed");
myProctectedDocumentProxy.DisplayDocument();

Console.ReadKey();

