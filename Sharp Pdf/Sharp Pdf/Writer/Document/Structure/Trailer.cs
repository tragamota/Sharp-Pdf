using System;
using System.Text;
using SharpPdf.Writer.Primitives;

namespace SharpPdf.Writer.Document.Structure
{
    internal class Trailer
    {
        private readonly CosDictionary _trailerDictionary;
        
        private int _xrefOffset;

        public Trailer()
        {
            _trailerDictionary = new CosDictionary();
            _xrefOffset = 0;
        }
        
        public void SetXrefByteOffset(int offset)
        {
            if (offset < 0)
                throw new ArgumentOutOfRangeException();

            _xrefOffset = offset;
        }

        public void ChangeCatalogObject(CosReference catalogRef)
        {
            _trailerDictionary["Root"] = catalogRef;
        }

        public void ChangeXrefSize(CosInteger xrefSize)
        {
            _trailerDictionary["Size"] = xrefSize;
        }

        public void ChangeInfoReference(CosReference infoRef)
        {
            _trailerDictionary["Info"] = infoRef;
        }

        public void GenerateFileIdentifier()
        {
            CosArray fileIdentifiers = new CosArray();
            
            //todo generate id's
        }

        public override string ToString()
        {
            StringBuilder trailerBuilder = new StringBuilder();

            trailerBuilder.AppendLine(WriteConstants.TrailerHeader);
            trailerBuilder.Append(_trailerDictionary);
            trailerBuilder.Append(WriteConstants.SingleBasedNewLine);
            trailerBuilder.AppendLine(WriteConstants.XRefHeader);
            trailerBuilder.AppendLine(_xrefOffset.ToString());
            trailerBuilder.Append(WriteConstants.EndOfFile);

            return trailerBuilder.ToString();
        }
    }
}