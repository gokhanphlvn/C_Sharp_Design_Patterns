// See https://aka.ms/new-console-template for more information
using Prototype;

Console.Title = ("Prototype Pattern");

var manager = new Manager("Gökhan");
var managerClone = (Manager)manager.Clone(true);
Console.WriteLine($"Manager was cloned: {managerClone.Name}");


var employee = new Employee("Batuhan", managerClone);
var employeeClone = (Employee)employee.Clone();
Console.WriteLine($"Employee was cloned: {employeeClone.Name} ,with manager: {employeeClone.Manager.Name} ");

managerClone.Name = "Elanur";
Console.WriteLine($"Manager name changed: {managerClone.Name}");
Console.WriteLine($"Employee was cloned: {employeeClone.Name} ,with manager: {employeeClone.Manager.Name} ");

Console.ReadKey();