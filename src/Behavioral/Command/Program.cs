// See https://aka.ms/new-console-template for more information
using Command.Commands;
using Command.Entities;
using Command.Repositories;

Console.Title = ("Command Pattern");

CommandManager commandManager = new();

IEmployeeManagerRepository employeeManagerRepository = new EmployeeManagerRepository();

commandManager.Invoke(new AddEmployeeToManagerListCommand(employeeManagerRepository, 1, new Employee(111, "Hüseyin")));
employeeManagerRepository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerListCommand(employeeManagerRepository, 1, new Employee(222, "Ali")));
employeeManagerRepository.WriteDataStore();

commandManager.Undo();
employeeManagerRepository.WriteDataStore();

commandManager.Invoke(new AddEmployeeToManagerListCommand(employeeManagerRepository, 2, new Employee(333, "Ömer")));
employeeManagerRepository.WriteDataStore();

var employee = new Employee(444, "Osman");
commandManager.Invoke(new AddEmployeeToManagerListCommand(employeeManagerRepository, 3, employee));
employeeManagerRepository.WriteDataStore();

commandManager.Invoke(new RemoveEmployeeToManagerListCommand(employeeManagerRepository, 3, employee));
employeeManagerRepository.WriteDataStore();

commandManager.UndoAll();
employeeManagerRepository.WriteDataStore();

Console.ReadKey();