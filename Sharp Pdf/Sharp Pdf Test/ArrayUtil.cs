using NUnit.Framework;
using SharpPdf.Utils;

namespace TestProject1
{
    public class UtilsTest
    {
        [Test]
        public void ConcatTwoArrays()
        {
            byte[] array1 = {22, 55, 66, 44, 22};
            byte[] array2 = {16, 14, 23};

            byte[] concatArrays = ArrayUtil.ConcatArrays(array1, array2);

            Assert.AreEqual(concatArrays, new byte[]
            {
                22, 55, 66, 44, 22, 16, 14, 23
            });
        }

        [Test]
        public void ConcatMultipleArrays()
        {
            byte[] array1 = {22, 55, 66, 44, 22};
            byte[] array2 = {16, 14, 23};
            byte[] array3 = {55, 66, 88};

            byte[] concatArrays = ArrayUtil.ConcatArrays(array1, array2, array3);

            Assert.AreEqual(concatArrays, new byte[]
            {
                22, 55, 66, 44, 22, 16, 14, 23, 55, 66, 88
            });
        }
    }
}