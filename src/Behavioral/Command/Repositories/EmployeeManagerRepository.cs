﻿using Command.Entities;

namespace Command.Repositories
{
    /// <summary>
    /// Receiver (implementation)
    /// </summary>
    public class EmployeeManagerRepository : IEmployeeManagerRepository
    {
        private IList<Manager> _managers = new List<Manager>() {
            new Manager(1,"Gökhan"),
            new Manager(2,"Elanur"),
            new Manager(3,"Batuhan")
        };
        public void AddEmployee(int managerId, Employee employee)
        {
            _managers.First(i => i.Id == managerId).Employees.Add(employee);
        }

        public bool HasEmployee(int managerId, int employeeId)
        {
            return _managers.First(i => i.Id == managerId).Employees.Any(a => a.Id == employeeId);
        }

        public void RemoveEmployee(int managerId, Employee employee)
        {
            _managers.First(i => i.Id == managerId).Employees.Remove(employee);
        }

        public void WriteDataStore()
        {
            foreach (var manager in _managers)
            {
                Console.WriteLine($"Manager {manager.Id}, {manager.Name}");
                if (manager.Employees.Any())
                {
                    foreach (var employee in manager.Employees)
                    {
                        Console.WriteLine($"\t Employee {employee.Id}, {employee.Name}");
                    }
                }
                else
                {
                    Console.WriteLine($"\t No employees");
                }
            }
            Console.WriteLine();
        }
    }
}
