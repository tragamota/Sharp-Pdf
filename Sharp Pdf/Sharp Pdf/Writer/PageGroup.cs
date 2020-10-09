using System.Collections.Generic;
using SharpPdf.Page;

namespace SharpPdf.Writer
{
    internal class PageGroup
    {
        public List<PdfPage> GroupedPages => new List<PdfPage>();
    }
}