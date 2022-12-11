// See https://aka.ms/new-console-template for more information
using TemplateMethod;

Console.Title = ("Template Method Pattern");

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("6EB5861D-B2F7-4332-B5D9-07F7462A7238"));
Console.WriteLine();


ApacheMailParser apacheMailParser= new();
Console.WriteLine(apacheMailParser.ParseMailBody("137A5F48-5F58-423B-B668-BC676245BEAE"));
Console.WriteLine();


EudoraMailParser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("74561D79-E020-4B75-BE6C-5B812BA6EC2B"));
Console.WriteLine();

Console.ReadLine();