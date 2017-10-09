using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSBench
{
    /// <summary>
    /// Essential a File - for Types and Components
    /// </summary>
    public class Container : SchemaObject
    {
        public List<Package> Packages = new List<Package>();
        public List<Import> Imports = new List<Import>();
        public List<Component> Components = new List<Component>();
        public List<Type> Types = new List<Type>();
    }
}
