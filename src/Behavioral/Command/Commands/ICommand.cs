namespace Command.Commands
{
    /// <summary>
    /// Command
    /// </summary>
    public interface ICommand
    {
        void Execute();
        bool CanExecute();
        void Undo();
    }
}
