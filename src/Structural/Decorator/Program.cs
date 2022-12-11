// See https://aka.ms/new-console-template for more information
using Decorator;

Console.Title = ("Decorator Pattern!");

var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Selam");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("Selam");

//add behavior
var statisticsDecorator = new StatisticsDecorator(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wrapper");

//add behavior
var messageDatabaseDocerator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDocerator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper message 1.");

messageDatabaseDocerator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper message 2.");

foreach (var message in messageDatabaseDocerator.SentMessages)
{
    Console.WriteLine($"Stored message {message}");
}

Console.ReadKey();