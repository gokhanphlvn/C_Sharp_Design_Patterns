// See https://aka.ms/new-console-template for more information
using Flyweight;

Console.Title = ("Flyweight Pattern");

var aBunchOfCharacters = "abba";
var characterFactory = new CharacterFactory();
// Get the flyweight
var charaterObject = characterFactory.GetCharacter(aBunchOfCharacters[0]);
// Pass through extrinsic state
charaterObject?.Draw("Arial", 12);
Console.WriteLine();
charaterObject = characterFactory.GetCharacter(aBunchOfCharacters[1]);
charaterObject?.Draw("Threbuchet MS", 14);
Console.WriteLine();
charaterObject = characterFactory.GetCharacter(aBunchOfCharacters[2]);
charaterObject?.Draw("Times New Roman", 16);
Console.WriteLine();
charaterObject = characterFactory.GetCharacter(aBunchOfCharacters[3]);
charaterObject?.Draw("Comic Snas", 18);
Console.WriteLine();
var paragraph = characterFactory.CreateParagraph(new List<ICharacter> { charaterObject }, 1);
paragraph.Draw("Lucinda", 19);
Console.ReadKey();