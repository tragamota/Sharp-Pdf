using System;

namespace Sharp_Pdf
{
    public class PdfPageDimension
    {
        public const PdfPageDimension A0 = new PdfPageDimension();
        public const PdfPageDimension A1 = null;
        public const PdfPageDimension A2 = null;
        public const PdfPageDimension A3 = null;
        public const PdfPageDimension A4 = null;
        public const PdfPageDimension A5 = null;
        public const PdfPageDimension Letter = null;

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