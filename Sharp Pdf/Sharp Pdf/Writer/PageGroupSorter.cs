using System.Collections.Generic;

namespace SharpPdf.Writer
{
    internal class RootGrouper
    {
        private PdfDocument _internalDocumentReference;
        
        public RootGrouper(ref PdfDocument document)
        {
            _internalDocumentReference = document;
        }
        
        public List<PageGroup> GroupPages()
        {
            return null;
        }
    }
}