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

        private const string StartObject = "obj";
        private const string EndObject = "endobj";

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

        private readonly int _objectNumber;
        private readonly int _revision;
        private ICosBase _objectItem;

        public CosObject(int objectNumber, int revision) : this(objectNumber, revision, null) {} 

        public CosObject(int objectNumber, int revision, ICosBase objectItem)
        {
            _objectNumber = objectNumber;
            _revision = revision;
           
            if(IsValidInternalObject(objectItem))
                _objectItem = objectItem;
        }
        
        private static bool IsValidInternalObject(ICosBase internalObject)
        {
            return internalObject.GetCosType() != CosType.Object;
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
            StringBuilder cosObjectBuilder = new StringBuilder();

            cosObjectBuilder.Append(_objectNumber.ToString());
            cosObjectBuilder.Append(' ');
            cosObjectBuilder.Append(_revision.ToString());
            cosObjectBuilder.Append(' ');
            cosObjectBuilder.AppendLine(StartObject);

            cosObjectBuilder.AppendLine(_objectItem.ToString());
            cosObjectBuilder.Append(EndObject);

            return cosObjectBuilder.ToString();
        }
    }
}