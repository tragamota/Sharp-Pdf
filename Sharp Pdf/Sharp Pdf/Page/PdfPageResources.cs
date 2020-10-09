using System.Collections.Generic;
using SharpPdf.Writer.Primitives;

namespace SharpPdf.Page
{
    internal class PdfPageResources
    {
        private List<Font.Font> _fonts;
        private List<int> _annotations;
        private List<ICosBase> _resources;
    }
}