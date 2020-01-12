using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosString : ICosBase
    {
        private const CosType Type = CosType.String;

        private readonly string _string;
        
        public CosString(string str)
        {
            _string = str;
        }
        
        public CosType GetCosType()
        {
            return CosType.String;
        }

        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }
    }
}
