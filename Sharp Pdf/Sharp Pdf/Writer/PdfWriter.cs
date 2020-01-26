namespace SharpPdf.Writer
{
    public class PdfWriter
    {
        private readonly PdfDocument _internalDocumentReference;
        private readonly DocumentCache _documentCache;

        private readonly RootGrouper _pageRootGrouper;

        public PdfWriter(ref PdfDocument document)
        {
            _internalDocumentReference = document;
            _documentCache = new DocumentCache();

        }
        
        public byte[] GenerateDocument()
        {


            return null;
        }
        
    }
}