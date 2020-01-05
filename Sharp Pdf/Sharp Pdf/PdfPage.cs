namespace Sharp_Pdf
{
    public class PdfPage
    {
        private int _pageNumber;
        private PdfPageDimension _pageDimension;

        internal PdfPage(PdfPageDimension pageDimension)
        {
            _pageDimension = pageDimension;
        } 
    }
}