using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulation.Simulation.Resources
{
    public class ResourceType
    {
        public string Name { get; set; }
        public string Unit { get; set; }

        public ResourceType(string name, string unit)
        {
            Name = name;
            Unit = unit;
        }

    }

    public class ResourceTypeComparer : IEqualityComparer<ResourceType>
    {
        public bool Equals(ResourceType x, ResourceType y)
        {
            return x.Name.Equals(y.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        public int GetHashCode(ResourceType obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
