﻿namespace SharpPdf.Page
{
    public class PdfPage
    {
        public PdfPageInfo PageInfo
        {
            get { return _pageInfo; }
        }

        private PdfPageInfo _pageInfo;
        private PdfPageResources _pageResources;

        internal PdfPage(int pageNumber, PdfPageDimension pageDimension)
        { 
            _pageInfo = new PdfPageInfo(pageNumber, pageDimension);
        }
    }
}