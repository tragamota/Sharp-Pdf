namespace SharpPdf.Writer
{
    internal class DocumentCache
    {
        public byte[] DocumentBuffer
        {
            get { return _rawDocumentBuffer; }
        }

        private string _documentHash;
        private byte[] _rawDocumentBuffer;

        public bool IsDocumentUnchanged(PdfDocument document)
        {
            return false;
        }

        public void AssignDocumentHash(PdfDocument document)
        {
            
        }
    }
}