using SharpPdf.Writer.Primitives;

namespace SharpPdf.Writer.Document.Structure
{
    public class Trailer
    {
        private const string TrailerHeader = "trailer";
        private const string XRefHeader = "startxref";

        private CosDictionary _trailerDictionary;
        private int _xRefOffset;

        public Trailer()
        {
            _trailerDictionary = new CosDictionary();
            _xRefOffset = 0;
        }
        
        
    }
}