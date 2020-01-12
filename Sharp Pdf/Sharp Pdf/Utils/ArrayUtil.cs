using System;
using System.Linq;

namespace SharpPdf.Utils
{
    public static class ArrayUtil
    {
        public static byte[] ConcatArrays(params byte[][] arrays)
        {
            byte[] totalBytes = new byte[arrays.Sum(arr => arr.Length)];

            int totalBytesWriten = 0;
            
            foreach (var arr in arrays)
            {
                Array.Copy(arr, 0, totalBytes, totalBytesWriten, arr.Length);
                totalBytesWriten += arr.Length;
            }

            return totalBytes;
        }
    }
}