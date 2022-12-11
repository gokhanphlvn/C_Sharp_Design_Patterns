using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsibility
{
    public class DocumentApprovedByLitigationHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            if (document != null)
            {
                if (document.ApprovedByLitigation)
                {
                    _successor?.Handle(document);
                }
                else
                {
                    throw new ValidationException(new ValidationResult("Document must be approved by litigation", new List<string> { "ApprovedByLitigation" }), null, null);
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
