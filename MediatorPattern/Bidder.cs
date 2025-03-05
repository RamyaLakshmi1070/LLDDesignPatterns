using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Bidder : IColleague
    {
        String Name;
        IMediator mediator;
        public Bidder(string name, IMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
            mediator.Add(this);
        }
        public string GetName()
        {
            return Name;
        }

        public void PlaceBid(int amount)
        {
            mediator.PlaceBid(this, amount);
        }

        public void ReceiveNotification(int amount)
        {
            Console.WriteLine("{0} has placed an Bid amount of Rupees : {1}", Name,amount);
        }
    }
}
