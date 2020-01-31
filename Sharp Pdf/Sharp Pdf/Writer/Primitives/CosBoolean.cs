using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosBoolean : ICosBase
    {
        private const CosType Type = Primitives.CosType.Boolean;

        private const string True = "true";
        private const string False = "false";

        private readonly bool _boolean;

        public CosBoolean(bool boolean)
        {
            _boolean = boolean;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes(_boolean ? True : False);
        }

        public override string ToString()
        {
            return _boolean ? True : False;
        }
    }
}
