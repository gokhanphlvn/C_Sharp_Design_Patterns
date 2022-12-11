using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DocumentApprovedByManagementHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;
        public void Handle(Document document)
        {
            if (document != null)
            {
                if (document.ApprovedByManagement)
                {
                    _successor?.Handle(document);
                }
                else
                {
                    throw new ValidationException(new ValidationResult("Document must be approved by Management", new List<string> { "ApprovedByManagement" }), null, null);
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
