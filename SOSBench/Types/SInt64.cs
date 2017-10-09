using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench.Types
{
    /// <summary>
    /// Variable-length zig-zag encoding; smaller absolute values use fewer bits. More space-efficient than int32 or int64 when values are likely to be negative.
    /// </summary>
    public class SInt64 : BaseType
    {

    }
}
