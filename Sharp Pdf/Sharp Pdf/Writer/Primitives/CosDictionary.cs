using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosDictionary : ICosBase
    {
        private const CosType Type = Primitives.CosType.Dictionary;
        
        public ICosBase this[string key]
        {
            get => _dictionary[new CosName(key)];
            set => _dictionary[new CosName(key)] = value;
        }

        private readonly Dictionary<CosName, ICosBase> _dictionary;

        public CosDictionary()
        {
            _dictionary = new Dictionary<CosName, ICosBase>();
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public void Add(CosName key, ICosBase value) 
        {
            _dictionary.Add(key, value);
        }

        public void Add(string key, ICosBase value)
        {
            _dictionary.Add(new CosName(key), value);
        }

        public void Remove(CosName key)
        {
            _dictionary.Remove(key);
        }

        public void Remove(string key)
        {
            _dictionary.Remove(new CosName(key));
        }
        
        public byte[] ToBinaryValue()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder dictionaryBuilder = new StringBuilder();

            dictionaryBuilder.AppendLine(WriteConstants.DictionaryOpening);
            
            foreach(KeyValuePair<CosName, ICosBase> valuePair in _dictionary)
            {
                dictionaryBuilder.Append(valuePair.Key.ToString());
                dictionaryBuilder.Append(' ');
                dictionaryBuilder.AppendLine(valuePair.Value.ToString());
            }

            dictionaryBuilder.Append(WriteConstants.DictionaryClosing);

            return dictionaryBuilder.ToString();
        }
    }
}
