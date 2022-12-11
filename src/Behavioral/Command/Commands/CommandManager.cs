namespace Command.Commands
{
    /// <summary>
    /// Invoker
    /// </summary>
    public class CommandManager
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();
        public void Invoke(ICommand command)
        {
            if (command.CanExecute())
            {
                command.Execute();
                _commands.Push(command);
            }
        }

        public void Undo()
        {
            if (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }

        public void UndoAll()
        {
            while (_commands.Any())
            {
                _commands.Pop()?.Undo();
            }
        }
    }
}
