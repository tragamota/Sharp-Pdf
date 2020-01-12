using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosArray : ICosBase
    {
        private const CosType Type = Primitives.CosType.Array;
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }
    }
}
