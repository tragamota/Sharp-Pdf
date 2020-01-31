using System.Text;

namespace SharpPdf.Writer.Document.Structure
{
    internal class XReferenceItem
    {
        public int ByteOffset
        {
            get => _byteOffset;
            set => _byteOffset = value;
        }

        public short Generation
        {
            get => _generation;
            set => _generation = value;
        }

        public bool InUse
        {
            get => _inUse;
            set => _inUse = value;
        }

        private int _byteOffset;
        private short _generation;
        private bool _inUse;

        public XReferenceItem()
        {
            _byteOffset = 0;
            _generation = 0;
            _inUse = false;
        }

        public override string ToString()
        {
            StringBuilder xrefLineBuilder = new StringBuilder();

            xrefLineBuilder.Append(_byteOffset.ToString("D10"));
            xrefLineBuilder.Append(' ');
            xrefLineBuilder.Append(_generation.ToString("D5"));
            xrefLineBuilder.Append(' ');
            xrefLineBuilder.Append(_inUse ? 'n' : 'f');
            xrefLineBuilder.Append("\r\n");

            return xrefLineBuilder.ToString();
        }
    }
}