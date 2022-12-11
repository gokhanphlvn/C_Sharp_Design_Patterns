using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility
{
    /// <summary>
    /// Concrete
    /// </summary>
    public class DocumentTitleHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            if (document != null)
            {
                if (document.Title != string.Empty)
                {
                    _successor?.Handle(document);
                }
                else
                {
                    throw new ValidationException(new ValidationResult("Title must be filled out", new List<string> { "Title" }), null, null);
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
