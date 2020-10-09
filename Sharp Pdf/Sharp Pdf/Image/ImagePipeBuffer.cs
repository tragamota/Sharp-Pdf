using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipelines;
using System.Threading.Tasks;
using SharpPdf.Utils;

namespace SharpPdf.Image.Loaders
{
    public class ImageMemoryPool
    {
        #region Properties
        public int SegmentSize => _bufferSize;
        
        public int t
        
        #endregion
        
        private LinkedList<Memory<byte>> _memorySegments;

        private int _totalBytes = 0;
        


        

        private const short _bufferSize = 4096;

        private int totalSize = 26 * _bufferSize;
        
        public ImageDataPool()
        {
            _PipeReader.ReadAsync();
        }


        public void Reset()
        {
            
        }
        
    }
}