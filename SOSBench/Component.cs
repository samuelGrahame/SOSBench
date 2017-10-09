using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class Component : SchemaBase
    {        
        public int Id;
        public Component(int _id)
        {
            Id = _id;
        }        
    }
}
