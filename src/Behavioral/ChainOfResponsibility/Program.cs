// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;
using System.ComponentModel.DataAnnotations;

Console.Title = "Chain of Responsibility";

var validDocument = new Document("How to Avoid c# Development", DateTimeOffset.UtcNow, true, true);
var invalidDocument = new Document("How to Avoid c# Development", DateTimeOffset.UtcNow, false, true);
var documentHandlerChain = new DocumentTitleHandler();

documentHandlerChain.SetSuccessor(new DocumentLastModifiedHandler())
                    .SetSuccessor(new DocumentApprovedByLitigationHandler())
                    .SetSuccessor(new DocumentApprovedByManagementHandler());

try
{
    documentHandlerChain.Handle(validDocument);
    Console .WriteLine("Valid Document is valid.");
    documentHandlerChain.Handle(invalidDocument);
    Console.WriteLine("InValid Document is valid.");
}
catch (ValidationException exValid)
{
    Console.WriteLine(exValid.Message);
}
Console.ReadKey();