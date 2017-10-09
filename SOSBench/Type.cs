using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class Type : SchemaBase
    {        
        public string Name;    
        public List<Type> NestedTypes = new List<Type>();


    }
}
