using Memento.Entities;
using Memento.Instance;
using Memento.Repositories;

namespace Memento.Commands
{
    /// <summary>
    /// Concete Command & Originator
    /// </summary>
    public class AddEmployeeToManagerListCommand : ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private int _managerId;
        private Employee? _employee;

        public AddEmployeeToManagerListCommand(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee? employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerId = managerId;
            _employee = employee;
        }

        public AddEmployeeToManagerListMemento CreateMemento()
        {
            return new AddEmployeeToManagerListMemento(_managerId, _employee);
        }

        public void RestoreMemento(AddEmployeeToManagerListMemento memento)
        {
            _managerId = memento.ManagerId;
            _employee = memento.Employee;
        }

        public bool CanExecute()
        {
            if (_employee is null || _employeeManagerRepository.HasEmployee(_managerId, _employee.Id))
            {
                return false;
            }

            return true;
        }

        public void Execute()
        {
            if (_managerId > 0 && _employee is not null)
            {
                _employeeManagerRepository.AddEmployee(_managerId, _employee);
            }
        }

        public void Undo()
        {
            if (_managerId > 0 && _employee is not null)
            {
                _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
            }
        }
    }
}
