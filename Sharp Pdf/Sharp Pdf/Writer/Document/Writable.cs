namespace SharpPdf.Writer.Document
{
    public interface IWritable
    {
        byte[] ToWritableBinary();
    }
}