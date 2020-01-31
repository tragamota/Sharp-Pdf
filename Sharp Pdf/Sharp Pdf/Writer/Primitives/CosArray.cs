using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosArray : ICosBase
    {
        private const CosType Type = Primitives.CosType.Array;

        private List<ICosBase> arrayItems = new List<ICosBase>();
        
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
