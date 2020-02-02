using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosArray : ICosBase
    {
        private const CosType Type = Primitives.CosType.Array;

        private List<ICosBase> _arrayItems = new List<ICosBase>();

        public CosArray()
        {
            _arrayItems = new List<ICosBase>();
        }

        private bool IsValidArrayItem(ICosBase item)
        {
            return item.GetCosType() == CosType.Object;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public void Add(ICosBase item)
        {
            if(IsValidArrayItem(item))
                throw new ArgumentException("Array can't contain a Object");
                
            _arrayItems.Add(item);
        }

        public void Remove(int index)
        {
            _arrayItems.RemoveAt(index);
        }
        
        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder arrayBuilder = new StringBuilder();

            arrayBuilder.Append(WriteConstants.ArrayOpening);
            foreach (var arrayItem in _arrayItems)
            {
                arrayBuilder.Append(' ');
                arrayBuilder.Append(arrayItem);
            }
            arrayBuilder.Append(WriteConstants.ArrayClosing);

            return arrayBuilder.ToString();
        }
    }
}
