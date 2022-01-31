using System.Collections.Generic;
using System.Linq;
using EconomySimulation.Simulation.Agent;
using EconomySimulation.Simulation.Resources;

namespace EconomySimulation.Simulation.Trade
{
    public enum OfferType
    {
        ASK,
        BID
    }
    public class Offer
    {
        public int Timestamp { get; }
        public IAgent Who { get; }
        public Resource Item { get; }

        public OfferType Type { get; }

        public Offer(IAgent who, Resource a, OfferType type)
        {
            Who = who;
            Item = a;
            Type = type;
            Timestamp = Simulation.CurrentTimestamp;
        }
    }
    public class Market
    {
        public string Name { get; set; }

        public IEnumerable<IAgent> Agents
        {
            get
            {
                return _agents.AsEnumerable();
            }
        }

        public IEnumerable<Offer> Offers
        {
            get
            {
                return _offers.AsEnumerable();
            }
        }

        protected List<IAgent> _agents;
        protected List<Offer> _offers;

        public Market(string name)
        {
            Name = name;
            _agents = new List<IAgent>();
            _offers = new List<Offer>();
        }

        public void CreateOffer(Offer offer)
        {
            if(_agents.Contains(offer.Who))
                _offers.Add(offer);
        }

        public void AddAgent(IAgent agent)
        {
            _agents.Add(agent);
        }

        public void Step()
        {

        }

    }
}
