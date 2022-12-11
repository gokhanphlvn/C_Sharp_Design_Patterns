using Memento.Instance;

namespace Memento.Commands
{
    /// <summary>
    /// Invoker & Caretaker
    /// </summary>
    public class CommandManager
    {
        private readonly Stack<AddEmployeeToManagerListMemento> _mementos = new();
        private AddEmployeeToManagerListCommand? _command;
        public void Invoke(ICommand command)
        {
            if (_command == null)
            {
                _command = (AddEmployeeToManagerListCommand)command;
            }
            if (command.CanExecute())
            {
                command.Execute();
                _mementos.Push(((AddEmployeeToManagerListCommand)command).CreateMemento());
            }
        }

        public void Undo()
        {
            if (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }

        public void UndoAll()
        {
            while (_mementos.Any())
            {
                _command?.RestoreMemento(_mementos.Pop());
                _command?.Undo();
            }
        }
    }
}
