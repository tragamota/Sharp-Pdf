using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using SharpPdf.Page;
using SharpPdf.Writer;

namespace SharpPdf
{
    public class PdfDocument
    {
        #region Props

        public PdfDocumentInformation DocumentInfo => _documentInfo;
        public ReadOnlyCollection<PdfPage> Pages => _pages.AsReadOnly();
        public int TotalPages => _pages.Count;

        #endregion

        internal readonly PdfDocumentInformation _documentInfo;
        internal readonly PdfWriter _documentWriter;

        internal readonly List<PdfPage> _pages;

        public PdfDocument()
        {
            _pages = new List<PdfPage>();
            _documentWriter = new PdfWriter(this);
            _documentInfo = new PdfDocumentInformation();
        }

        public PdfPage GetPage(int pageNumber)
        {
            var totalPages = _pages.Count;

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

            if (dimension != null)
                _pages.Add(pageToAdd = new PdfPage(_pages.Count + 1, dimension));
            else
                throw new Exception("Dimensions out of range");

            return pageToAdd;
        }

        public void RemovePage(PdfPage page)
        {
            _pages.Remove(page);
        }

        public void RemovePage(int index)
        {
            var totalPages = _pages.Count;

            if (!(index < 0 || index >= totalPages))
            {
                _pages.RemoveAt(index);
            }
        }

        public byte[] AsBinary()
        {
            //check if document has 1 or more pages
            if (_pages.Any())
                throw new Exception("Document must have pages.");

            return _documentWriter.GenerateDocument();
        }

        public async Task<byte[]> AsBinaryAsync()
        {
            //check if document has 1 or more pages
            if (_pages.Any())
                throw new Exception("Document must have pages.");

            return await Task.Run(() => _documentWriter.GenerateDocument());
        }

        public void Save(string filePath)
        {
            if (!IsValidFileExtension(Path.GetExtension(filePath)))
                throw new WarningException("The file extension is not .pdf");

            byte[] data = AsBinary();

            using (var stream = File.Open(filePath, FileMode.Create))
                stream.WriteAsync(data, 0, data.Length);
        }

        public async Task SaveAsync(string filePath)
        {
            if (!IsValidFileExtension(Path.GetExtension(filePath)))
                throw new WarningException("The file extension is not .pdf.");

            byte[] data = await AsBinaryAsync();

            using (var stream = File.Open(filePath, FileMode.Create))
                await stream.WriteAsync(data, 0, data.Length);
        }

        private static bool IsValidFileExtension(string fileExtension)
        {
            if (fileExtension == null)
                return false;

            return fileExtension.ToLower() == ".pdf";
        }
    }
}