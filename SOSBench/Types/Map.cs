using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench.Types
{
    /// <summary>
    ///  the keys to a map can only be an integral type, enumeration type, string or EntityId
    /// </summary>
    public class Map : BaseType
    {
        public BaseType K;
        public BaseType V;
    }
}
