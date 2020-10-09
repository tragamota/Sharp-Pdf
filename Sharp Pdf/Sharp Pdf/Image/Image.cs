namespace SharpPdf.Image
{
    public abstract class Image
    {
        public ImageType Type { get; set; }

        protected Image(ImageType type)
        {
            this.Type = type;
        }
        
        // public virtual 
    }
}