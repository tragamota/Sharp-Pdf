using System;
using System.Text;

namespace SharpPdf.Writer.Document.Structure
{
    internal class GeneralHeader
    {
        private const string VersionLine = "%PDF-";
        private const string BinarySignature = "%¼½¾¿";

        private PdfVersion _version;

        public GeneralHeader(PdfVersion version)
        {
            _version = version;
        }

        public override string ToString()
        {
            StringBuilder headerBuilder = new StringBuilder();

            headerBuilder.Append(VersionLine);
            headerBuilder.AppendLine(_version.ToString());
            headerBuilder.Append(BinarySignature);

            return headerBuilder.ToString();
        }
    }
}