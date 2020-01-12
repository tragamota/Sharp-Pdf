using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosReal : ICosBase
    {
        private const CosType Type = CosType.Real;

        private readonly float _real;
        
        public CosReal(float real)
        {
            _real = real;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes(_real.ToString());
        }
    }
}
