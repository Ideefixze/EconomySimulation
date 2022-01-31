using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EconomySimulation.Simulation.Resources;
using EconomySimulation.Simulation.Trade;

namespace EconomySimulation.Simulation
{
    public class Simulation
    {
        public static int CurrentTimestamp = 0;
        public IEnumerable<Market> Markets
        {
            get
            {
                return _markets.AsEnumerable();
            }
        }

        private HashSet<ResourceType> _resourceTypes;
        private HashSet<Market> _markets;

        public Simulation()
        {
            _resourceTypes = new HashSet<ResourceType>(new ResourceTypeComparer());
            _markets = new HashSet<Market>();
        }

        public void DefineResourceType(ResourceType type)
        {
            _resourceTypes.Add(type);
        }

        public void DefineMarket(Market market)
        {
            _markets.Add(market);
        }

        public void Step()
        {
            foreach (var market in _markets)
            {
                market.Step();
            }
        }
    }
}
