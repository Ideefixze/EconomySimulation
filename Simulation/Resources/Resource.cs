using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EconomySimulation.Simulation.Resources
{
    public struct Resource
    {
        public ResourceType Type { get; }
        public decimal Amount { get; set; }

        public Resource(ResourceType type, decimal amount)
        {
            Type = type;
            Amount = amount;
        }

        public override string ToString()
        {
            return Amount.ToString() + Type.Unit +" of " + Type.Name;
        }
    }
}
