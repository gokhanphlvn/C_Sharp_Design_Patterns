namespace Proxy
{
    /// <summary>
    /// Proxy
    /// </summary>
    public class DocumentProxy : IDocument
    {
        private string _fileName;
        private Lazy<Document> _document;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
            _document = new Lazy<Document>(() => new Document(_fileName));
        }


        public void DisplayDocument()
        {
            _document.Value.DisplayDocument();
        }
    }
}
