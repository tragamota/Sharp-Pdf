namespace SharpPdf.Page
{
    public class PdfPageInfo
    {
        public int PageNumber { get; internal set; } 
        public PdfPageRotation Rotation { get; set; }
        public PdfPageDimension Dimension { get; internal set;  }

        internal PdfPageInfo(int pageNumber, PdfPageDimension dimension)
        {
            PageNumber = pageNumber;
            Dimension = dimension;
            Rotation = PdfPageRotation.ZERO_DEGREES;
        }
    }
}