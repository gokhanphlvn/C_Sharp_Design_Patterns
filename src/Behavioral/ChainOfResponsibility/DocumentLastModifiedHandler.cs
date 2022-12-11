using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility
{
    public class DocumentLastModifiedHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            if (document != null)
            {
                if (document.LastModified < DateTimeOffset.UtcNow.AddDays(-30))
                {
                    throw new ValidationException(new ValidationResult("Document must be modified in the last 30 dats", new List<string> { "LastModified" }), null, null);
                }
                else
                {
                    _successor?.Handle(document);
                }
            }
            else
            {
                throw new NullReferenceException("document required");
            }
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;
            return successor;
        }
    }
}
