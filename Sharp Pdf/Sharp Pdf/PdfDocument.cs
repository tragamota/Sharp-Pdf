using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;

namespace Sharp_Pdf
{
    public class PdfDocument
    {
        public PdfDocumentInformation DocumentInfo
        {
            get { return _documentInfo; }
        }

        public ReadOnlyCollection<PdfPage> Pages
        {
            get { return _pages.AsReadOnly(); }
        }

        private readonly PdfDocumentInformation _documentInfo;
        private readonly List<PdfPage> _pages;

        public PdfDocument()
        {
            _documentInfo = new PdfDocumentInformation();
            _pages = new List<PdfPage>();
        }

        public int TotalPages()
        {
            return _pages.Count;
        }

        public PdfPage GetPage(int pageNumber)
        {
            var totalPages = TotalPages();

            if (!((pageNumber < 0) || (pageNumber >= totalPages)))
            {
                return _pages[pageNumber];
            }

            return default;
        }

        public PdfPage AddPage(PdfPageDimension dimension)
        {
            PdfPage pageToAdd;
            
            _pages.Add(pageToAdd = new PdfPage());

            return pageToAdd;
        }

        public void RemovePage(PdfPage page)
        {
            _pages.Remove(page);
        }

        public void RemovePage(int index)
        {
            var totalPages = TotalPages();
            
            if(!((index < 0) || (index >= totalPages))) {
                _pages.RemoveAt(index);
            }
        }

        public byte[] AsBinary()
        {
            
        }

        public void Save(string filePath)
        {
            
        }
    }
}