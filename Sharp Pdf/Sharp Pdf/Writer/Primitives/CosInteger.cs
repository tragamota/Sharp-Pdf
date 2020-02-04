using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosInteger : ICosBase
    {
        private const CosType Type = Primitives.CosType.Integer;

        private readonly int _integer;
        
        public CosInteger(int integer)
        {
            _integer = integer;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }
        
        public byte[] ToBinaryValue()
        { 
            return Encoding.Unicode.GetBytes(_integer.ToString());
        }

        public override string ToString()
        {
            return _integer.ToString();
        }
        
        public static CosInteger operator +(CosInteger left, CosInteger right)
        {
            return new CosInteger(left._integer + right._integer);
        }

        public static CosInteger operator +(CosInteger left, int right)
        {
            return new CosInteger(left._integer + right);
        }
    }
}
