using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosDictionary : ICosBase
    {
        private const CosType Type = Primitives.CosType.Dictionary;

        private const string DictionaryOpening = "<<";
        private const string DictionaryClosing = ">>";

        private readonly Dictionary<CosName, ICosBase> _dictionary;

        public CosDictionary()
        {
            
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public void Add(CosName key, ICosBase value) 
        {
            _dictionary.Add(key, value);
        }

        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }
    }
}
