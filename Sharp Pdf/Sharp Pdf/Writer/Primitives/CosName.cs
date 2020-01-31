using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosName : ICosBase
    {
        private const CosType Type = Primitives.CosType.Name;

        private readonly string _name;

        public CosName(string name)
        {
            _name = name;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes('/' + _name);
        }

        public override string ToString()
        {
            return "/" + _name;
        }
    }
}
