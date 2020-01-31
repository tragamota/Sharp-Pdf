using System;
using System.Collections.Generic;
using System.Net;

namespace SharpPdf.Writer.Document.Structure
{
    internal class XRefTable : IWritable
    {
        public int StartIndex
        {
            get => _startIndex;
            set => ChangeStartIndex(value);
        }

        private int _totalObjects;
        private int _startIndex;
                
        private List<XReferenceItem> _references;

        public XRefTable()
        {
            _totalObjects = 1;
            _startIndex = 0;
            _references = new List<XReferenceItem>();
        }
        
        private void AddInitialReference()
        {
            _references.Add(new XReferenceItem());
        }

        public void ChangeStartIndex(int newIndex)
        {
            if (newIndex < 0)
                throw new ArgumentOutOfRangeException("Start index can't be smaller then zero");
            else if(newIndex > _totalObjects)
                throw new ArgumentOutOfRangeException("Start index can't exceed the amount of references");

            _startIndex = newIndex;
        }
        
        public void AddObjectReference(XReferenceItem item)
        {
            
        }

        public void RemoveObjectReference(int objectNumber)
        {
            
        }
        
        public byte[] ToWritableBinary()
        {
            throw new NotImplementedException();
        }
    }
}