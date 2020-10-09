using System;
using System.Text;
using SharpPdf.Writer;

namespace SharpPdf.Utils
{
    public class ByteEncoder
    {
        private static readonly Encoding ExtendedEncoding = Encoding.GetEncoding(WriteConstants.PdfEncoding);
        private static readonly Encoding TextEncoding = Encoding.BigEndianUnicode;
        
        public static byte[] StringEncoding(string text)
        {
            return text == null ? null : TextEncoding.GetBytes(text);
        }
        
        public byte[] StandardEncoding(string text)
        {
            return text == null ? null : ExtendedEncoding.GetBytes(text);
        }
    }
}