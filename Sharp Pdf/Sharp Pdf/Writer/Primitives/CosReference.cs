using System.Text;

namespace SharpPdf.Writer.Primitives
{
    internal class CosReference : ICosBase
    {
        private const CosType Type = CosType.Reference;

        private readonly int _objectNumber;
        private readonly int _revision;

        public CosReference(int objectNumber, int revision)
        {
            _objectNumber = objectNumber;
            _revision = revision;
        }
        
        public CosType GetCosType()
        {
            return Type;
        }

        public byte[] ToBinaryValue()
        {
            return Encoding.Unicode.GetBytes(_objectNumber.ToString() +
                                             " " + _revision.ToString() +
                                             " R");
        }

        public override string ToString()
        {
            StringBuilder referenceBuilder = new StringBuilder();

            referenceBuilder.Append(_objectNumber);
            referenceBuilder.Append(' ');
            referenceBuilder.Append(_revision);
            referenceBuilder.Append(' ');
            referenceBuilder.Append("R");

            return referenceBuilder.ToString();
        }
    }
}