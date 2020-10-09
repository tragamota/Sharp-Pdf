using System.Threading.Tasks;
using SharpPdf.Image.Loaders;
using SharpPdf.Utils;

namespace SharpPdf.Image
{
    public class ImageLoader
    {
        
        
        public ImageLoader()
        {
            
        }
        
        public Image LoadImage(byte[] rawImageData)
        {
            return null;
        }
        
        public Image LoadImage(FilePath path)
        {
            return null;
        }

        public Task<Image> LoadImageAsync(byte[] rawImageData)
        {
            return null;
        }

        public Task<Image> LoadImageAsync(FilePath path)
        {
            return null;
        }
    }
}