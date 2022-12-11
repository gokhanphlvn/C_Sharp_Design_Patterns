// See https://aka.ms/new-console-template for more information
using Iterator;

Console.Title = "Iterator";

PeopleCollection people = new();

people.Add(new Person("Gökhan", "Türkiye"));
people.Add(new Person("Gill", "Belgium"));
people.Add(new Person("Roland", "Germany"));
people.Add(new Person("Thomas", "France"));

var peopleIterator = people.CreateIterator();

for (Person person = peopleIterator.First(); !peopleIterator.IsDone; person = peopleIterator.Next())
{
    Console.WriteLine(person?.Name);
}

Console.ReadKey();
