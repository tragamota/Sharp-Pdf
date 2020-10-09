using System;
using System.Linq;

namespace SharpPdf.Utils
{
    public static class ArrayUtil
    {
        public static byte[] ConcatArrays(params byte[][] arrays)
        {
            byte[] totalBytes = new byte[arrays.Sum(arr => arr.Length)];

            var totalBytesWritten = 0;
            
            foreach (var arr in arrays)
            {
                Array.Copy(arr, 0, totalBytes, totalBytesWritten, arr.Length);
                totalBytesWritten += arr.Length;
            }

            return totalBytes;
        }
    }
}