namespace Decorator
{
    /// <summary>
    /// Component (as interface)
    /// </summary>
    public interface IMailService
    {
        bool SendMail(string message);
    }
}
