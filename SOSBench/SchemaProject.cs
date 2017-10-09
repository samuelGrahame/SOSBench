using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    public class SchemaProject : SchemaObject
    {
        /// <summary>
        /// Component Id;
        /// </summary>
        public int BaseId = 100;

        public int GetNewId()
        {            
            if (BaseId++ > 190000 && BaseId < 199999)
            {
                BaseId = 200000;
            }
            return BaseId;
        }

        public List<Container> Containers = new List<Container>();
    }
}
