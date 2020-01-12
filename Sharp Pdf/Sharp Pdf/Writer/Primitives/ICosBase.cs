using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPdf.Writer.Primitives
{
    interface ICosBase
    {
        CosType GetCosType();
        byte[] ToBinaryValue();
    }
}
