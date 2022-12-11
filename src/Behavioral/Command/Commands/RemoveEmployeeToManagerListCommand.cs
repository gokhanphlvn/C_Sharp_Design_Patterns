using Command.Entities;
using Command.Repositories;

namespace Command.Commands
{
    public class RemoveEmployeeToManagerListCommand : ICommand
    {
        private readonly IEmployeeManagerRepository _employeeManagerRepository;
        private readonly int _managerId;
        private readonly Employee _employee;

        public RemoveEmployeeToManagerListCommand(IEmployeeManagerRepository employeeManagerRepository, int managerId, Employee employee)
        {
            _employeeManagerRepository = employeeManagerRepository;
            _managerId = managerId;
            _employee = employee;
        }

        public bool CanExecute()
        {
            return _managerId > 0 &&
                   _employee is not null &&
                   _employeeManagerRepository.HasEmployee(_managerId, _employee.Id);
        }

        public void Execute()
        {
            if (_managerId > 0 && _employee is not null)
            {
                _employeeManagerRepository.RemoveEmployee(_managerId, _employee);
            }
        }

        public void Undo()
        {
            if (_managerId > 0 && _employee is not null)
            {
                _employeeManagerRepository.AddEmployee(_managerId, _employee);
            }
        }
    }
}
