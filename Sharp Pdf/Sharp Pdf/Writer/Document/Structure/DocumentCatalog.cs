using System.Collections.Generic;
using SharpPdf.Writer.Primitives;

namespace SharpPdf.Writer.Document.Structure
{
    public class DocumentCatalog
    {
        private readonly CosObject _document;
        private readonly CosDictionary _catalogDict;

        public DocumentCatalog()
        {
            _catalogDict = new CosDictionary();
            _catalogDict.Add(new CosName("Type"), new CosName("Catalog"));
            _catalogDict.Add(new CosName("Pages"), new CosReference(2, 0));
            _document = new CosObject(1, 0, _catalogDict);
        }

        public void AddPageRoot()
        {
            
        }
    }
}