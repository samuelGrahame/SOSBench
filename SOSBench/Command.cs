using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class Command : Property
    {
        public Command(int _id) : base(_id)
        {
        }
        public List<Types.BaseType> Arguments = null;
    }
}
