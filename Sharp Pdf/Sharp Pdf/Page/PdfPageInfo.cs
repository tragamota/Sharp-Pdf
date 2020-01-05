namespace SharpPdf.Page
{
    internal class PdfPageInfo
    {
        public int _pageNumber;
        public PdfPageRotation _rotation;
        public PdfPageDimension _dimension;

        internal PdfPageInfo(int pageNumber, PdfPageDimension dimension)
        {
            _pageNumber = pageNumber;
            _dimension = dimension;
            _rotation = PdfPageRotation.ZERO_DEGREES;
        }
    }
}