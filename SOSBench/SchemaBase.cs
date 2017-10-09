using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class SchemaBase : SchemaObject
    {
        /// <summary>
        /// Base for Component and Type
        /// </summary>
        public int BaseId;
        public List<Property> Properties = new List<Property>();
        
        public SchemaBase()
        {
            
        }
    }
}
