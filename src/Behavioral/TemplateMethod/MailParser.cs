namespace TemplateMethod
{
    /// <summary>
    /// abstract class
    /// </summary>
    public abstract class MailParser
    {
        public virtual void FindServer()
        {
            Console.WriteLine("Find Server...");
        }

        public abstract void AuthenticateToServer();

        /// <summary>
        /// Template Method
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public string ParseHtmlMailBody(string identifier)
        {
            Console.WriteLine($"Parsing HTML mail body");
            return $"This is the body of mail with id {identifier}";
        }

        public string ParseMailBody(string identifier)
        {
            Console.WriteLine($"Parsing mail body (in template method)...");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }
}
