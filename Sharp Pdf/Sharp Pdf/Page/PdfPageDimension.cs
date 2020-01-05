using System;

namespace SharpPdf.Page
{
    public class PdfPageDimension
    {
        public static readonly PdfPageDimension A0 = new PdfPageDimension(2384f, 3370f);
        public static readonly PdfPageDimension A1 = new PdfPageDimension(1685f, 2384f);
        public static readonly PdfPageDimension A2 = new PdfPageDimension(1190f, 1685f);
        public static readonly PdfPageDimension A3 = new PdfPageDimension(842f, 1190f);
        public static readonly PdfPageDimension A4 = new PdfPageDimension(595f, 842f);
        public static readonly PdfPageDimension A5 = new PdfPageDimension(420f, 595f);
        public static readonly PdfPageDimension Letter = new PdfPageDimension(612f, 792f);

        public float Width
        {
            get { return _width; }
        }

        public float Height
        {
            get { return _height; }
        }
        
        private float _width;
        private float _height; 
        
        public PdfPageDimension(float width, float height)
        {
            if(width <= 0f || height <= 0f)
                throw new ArgumentException();

            _width = width;
            _height = height;
        }

        public override string ToString()
        {
            return "{\n" +
                   "\ttype: " + GetType().Name + "\n" +
                   "\twidth: " + _width + "\n" +
                   "\theight: " + _height + "\n" +
                   "}";
        }
    }
}