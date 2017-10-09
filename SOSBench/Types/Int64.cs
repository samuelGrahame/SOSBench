using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench.Types
{
    /// <summary>
    /// Variable-length encoding; smaller values use fewer bits. Negative values are represented in the usual two’s-complement manner, and so use the maximum number of bits.
    /// </summary>
    public class UInt64 : BaseType
    {
    }
}
