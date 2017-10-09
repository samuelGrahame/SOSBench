using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class Property : SchemaObject
    {
        public int Id;

        public Property(int _id)
        {
            Id = _id;
        }

        public string Name;
        public Types.BaseType PropertyType = null;        
    }
}
