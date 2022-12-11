namespace Decorator
{
    public class StatisticsDecorator : MailServiceDecoratorBase
    {
        public StatisticsDecorator(IMailService mailService) : base(mailService) { }

        public override bool SendMail(string message)
        {
            Console.WriteLine($"Collection statics in {nameof(StatisticsDecorator)}.");
            return base.SendMail(message);
        }
    }
}
