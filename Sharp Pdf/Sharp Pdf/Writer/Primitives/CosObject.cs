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
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            var header = Encoding.Unicode.GetBytes(_objectNumber.ToString() + " " +
                                                   _revision.ToString() + " " +
                                                   StartObject + "\n");
            var data = _objectItem.ToBinaryValue();
            var footer = Encoding.Unicode.GetBytes(EndObject + "\n");

            return ArrayUtil.ConcatArrays(header, data, footer);
        }

        private static bool IsValidInternalObject(ICosBase internalObject)
        {
            return internalObject.GetCosType() != CosType.Object;
        }
    }
}