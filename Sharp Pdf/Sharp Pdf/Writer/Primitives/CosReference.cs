﻿using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosReference : ICosBase
    {
        private const CosType Type = CosType.Reference;

        private readonly int _objectNumber;
        private readonly int _revision;

        public CosReference(int objectNumber, int revision)
        {
            _objectNumber = objectNumber;
            _revision = revision;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes(_objectNumber.ToString() +
                                             " " + _revision.ToString() +
                                             " R");
        }
    }
}