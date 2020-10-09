using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpPdf.Utils;

namespace SharpPdf.Writer.Primitives
{
    internal class CosObject : ICosBase
    {
        private const CosType Type = CosType.Object;

        public ICosBase InternalObject
        {
            get { return _objectItem; }
            set
            {
                if (value.GetCosType() != CosType.Object)
                    _objectItem = value;
                else
                    throw new NotSupportedException("CosObject can't contain Costype of object");
            }
        }

        public int ObjectNumber
        {
            get { return _objectNumber; }
        }

        public int Revision
        {
            get { return _revision; }
        }

        private readonly int _objectNumber;
        private readonly int _revision;
        private ICosBase _objectItem;

        public CosObject(int objectNumber, int revision, ICosBase objectItem = null)
        {
            _objectNumber = objectNumber;
            _revision = revision;

            if (IsValidInternalObject(objectItem))
                _objectItem = objectItem;
        }

        private bool IsValidInternalObject(ICosBase internalObject)
        {
            return internalObject?.GetCosType() != CosType.Object;
        }

        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.GetEncoding(WriteConstants.PdfEncoding).GetBytes(ToString());
        }

        public override string ToString()
        {
            var cosObjectBuilder = new StringBuilder();

            cosObjectBuilder.Append(_objectNumber.ToString());
            cosObjectBuilder.Append(' ');
            cosObjectBuilder.Append(_revision.ToString());
            cosObjectBuilder.Append(' ');
            cosObjectBuilder.AppendLine(WriteConstants.StartObject);

            cosObjectBuilder.AppendLine(_objectItem.ToString());
            cosObjectBuilder.Append(WriteConstants.EndObject);

            return cosObjectBuilder.ToString();
        }
    }
}