using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SharpPdf.Writer.Document.Structure
{
    internal class XRefTable
    {
        public int StartIndex
        {
            get => _startIndex;
            set => ChangeStartIndex(value);
        }
        
        public XReferenceItem this[int index]
        {
            get { return _references[index]; }
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
            _references.Add(new XReferenceItem()
            {
                ByteOffset = 0,
                Generation = short.MaxValue,
                InUse = false
            });
        }

        public void ChangeStartIndex(int newIndex)
        {
            if (newIndex < 0)
                throw new ArgumentOutOfRangeException("Starting index can't be smaller then zero");
            else if(newIndex > _totalObjects)
                throw new ArgumentOutOfRangeException("Starting index can't exceed the amount of references");

            _startIndex = newIndex;
        }
        
        public int AddObjectReference(XReferenceItem item)
        {
            _references.Add(item);

            return ++_totalObjects;
        }

        public void RemoveObjectReference(int objectNumber)
        {
            if (objectNumber < 0 || objectNumber >= _totalObjects)
                throw new ArgumentOutOfRangeException();
            
            _references.RemoveAt(objectNumber);

            _totalObjects--;
        }

        public override string ToString()
        {
            StringBuilder xrefBuilder = new StringBuilder();
            
            xrefBuilder.Append("xref");
            xrefBuilder.Append("\n");
            xrefBuilder.Append(_startIndex + ' ' + _totalObjects);
            xrefBuilder.Append("\n");

            foreach (XReferenceItem reference in _references)
            {
                xrefBuilder.Append(reference.ToString());
            }

            xrefBuilder.Append('\n');

            return xrefBuilder.ToString();
        }
    }
}