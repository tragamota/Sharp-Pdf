using SharpPdf.Writer.Document;
using SharpPdf.Writer.Document.Structure;

namespace SharpPdf.Writer
{
    public class PdfWriter
    {
        private readonly PdfDocument _internalDocumentReference;
        
        private readonly GeneralHeader _documentHeader;
        //private readonly 
        private readonly XRefTable _refTable;
        private readonly Trailer _trailer;
        
        private readonly DocumentCache _documentCache;
        
        private readonly RootGrouper _pageRootGrouper;

        public PdfWriter( PdfDocument document)
        {
            _documentHeader = new GeneralHeader();
            //add document item collection
            _refTable = new XRefTable();
            _trailer = new Trailer();
            
            _documentCache = new DocumentCache();
            
            _pageRootGrouper = new RootGrouper(ref document);

            _internalDocumentReference = document;
        }

        public byte[] GenerateDocument()
        {
            return null;
        }

        private void BuildPageRootTree()
        {
            PageRoot pageRootHead = new PageRoot(0, 0);

            foreach (var groupedPages in _pageRootGrouper.GroupPages())
            {
                
            }
        }
    }
}