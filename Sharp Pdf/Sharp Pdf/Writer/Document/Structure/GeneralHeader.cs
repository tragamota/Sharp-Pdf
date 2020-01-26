namespace SharpPdf.Writer.Document.Structure
{
    internal class GeneralHeader
    {
        private const string VersionLine = "%PDF-";
        private static readonly byte[] BinarySignature = { 37, 188, 189, 190, 191 };

        private PdfVersion _version;

        public GeneralHeader(PdfVersion version)
        {
            _version = version;
        }
    }
}