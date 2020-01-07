using System.Collections.Generic;

namespace SharpPdf
{
    public sealed class PdfDocumentInformation
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public IEnumerable<string> Keywords { get; set; }
    }
}