using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Threading.Tasks;

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

            if (!(pageNumber < 0 || pageNumber >= totalPages))
            {
                return _pages[pageNumber];
            }

            return default;
        }

        public PdfPage AddPage()
        {
            return AddPage(PdfPageDimension.A4);
        }
        
        public PdfPage AddPage(PdfPageDimension dimension)
        {
            PdfPage pageToAdd = null;
            
            if (dimension == null) 
                return pageToAdd;
            
            _pages.Add(pageToAdd = new PdfPage(dimension));

            return pageToAdd;
        }

        public void RemovePage(PdfPage page)
        {
            _pages.Remove(page);
        }

        public void RemovePage(int index)
        {
            var totalPages = TotalPages();
            
            if(!(index < 0 || index >= totalPages)) {
                _pages.RemoveAt(index);
            }
        }
        
        public byte[] AsBinary()
        {
            //check if document has 1 or more pages
            
            return null;
        }

        public async Task<byte[]> AsBinaryAsync()
        {
            //check if document has 1 or more pages
            
            return null;
        }
        
        public void Save(string filePath)
        {
            if (!IsValidFileExtension(Path.GetExtension(filePath)))
            {
                //print warning
            }
            
            using (var stream = File.Open(filePath, FileMode.Create))
            {
                stream.WriteByte((byte) 0);
            }
        }

        public async Task SaveAsync(string filePath)
        {
            if (!IsValidFileExtension(Path.GetExtension(filePath)))
            {
                //print warning
            }

            await using (var stream = File.Open(filePath, FileMode.Create))
            {
                byte[] data = new byte[] {1};
                
                await stream.WriteAsync(data, 0,data.Length);
            }
        }
        
        private bool IsValidFileExtension(string fileExtension)
        {
            if (fileExtension == null)
                return false;
            
            return fileExtension.ToLower() == "pdf";
        }
    }
}