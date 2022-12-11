namespace Decorator
{
    public class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService) { }

        public List<string> SentMessages { get; private set; } = new List<string>();

        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                SentMessages.Add(message);
                return true;
            }
            return false;
        }
    }
}
