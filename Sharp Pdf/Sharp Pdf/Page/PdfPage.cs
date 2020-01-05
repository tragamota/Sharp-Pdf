namespace SharpPdf.Page
{
    public class PdfPage
    {
        public int PageNumber
        {
            get { return _pageInfo._pageNumber; }
            internal set { _pageInfo._pageNumber = value; }
        }

        private PdfPageInfo _pageInfo;
        
        internal PdfPage(int pageNumber, PdfPageDimension pageDimension)
        {
           
        }
    }
}