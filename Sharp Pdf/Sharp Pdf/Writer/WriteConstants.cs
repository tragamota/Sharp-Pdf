namespace SharpPdf.Writer
{
    internal class WriteConstants
    {
        public const string PdfEncoding = "ISO-8859-1";
        
        public const string EndOfFile = "%%EOF";
        public const string SingleBasedNewLine = "\n";
        public const string DoubleBasedNewLine = "\r\n";
        
        public const string StartObject = "obj";
        public const string EndObject = "endobj";
        
        public const string DictionaryOpening = "<<";
        public const string DictionaryClosing = ">>";

        public const string ArrayOpening = "[";
        public const string ArrayClosing = "]";
        
        public const string TrailerHeader = "trailer";
        public const string XRefHeader = "startxref";
    }
}