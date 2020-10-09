using System;
using System.Text;

namespace SharpPdf.Writer.Document.Structure
{
    internal sealed class GeneralHeader
    {
        private const string VersionLine = "%PDF-1.7";
        private const string BinarySignature = "%¼½¾¿";
        
        public override string ToString()
        {
            StringBuilder headerBuilder = new StringBuilder();

            headerBuilder.AppendLine(VersionLine);
            headerBuilder.Append(BinarySignature);

            return headerBuilder.ToString();
        }
    }
}