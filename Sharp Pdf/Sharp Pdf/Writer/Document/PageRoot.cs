using SharpPdf.Writer.Primitives;

namespace SharpPdf.Writer.Document
{
    internal class PageRoot
    {
        private readonly CosObject _rootObject;
        private readonly CosDictionary _rootDict;

        private readonly CosArray _pageArray;
        
        private CosReference _parentReference;

        public PageRoot(int rootNumber, int generation)
        {
            _pageArray = new CosArray();

            _rootDict = new CosDictionary();
            _rootDict["Type"] = new CosName("Pages");
            
        }

        public void AddPageReference(CosReference pageRef)
        {
            _pageArray.Add(pageRef);
        }

        public void RemovePageReference(CosReference pageRef)
        {
            
        }
    }
}