using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosNull : ICosBase
    {
        private const CosType Type = Primitives.CosType.Null;
        
        private const string NullValue = "null";
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes(NullValue);
        }

        public override string ToString()
        {
            return NullValue;
        }
    }
}
