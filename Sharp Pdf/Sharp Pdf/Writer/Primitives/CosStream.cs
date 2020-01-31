using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosStream : ICosBase
    {
        private const CosType Type = CosType.Stream;

        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return null;
        }
    }
}
