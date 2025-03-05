using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class AuctionMediator : IMediator
    {
        List<IColleague> lst = new List<IColleague>();
        public void Add(IColleague colleague)
        {
            lst.Add(colleague);
        }

        public void PlaceBid(IColleague colleague,int amount)
        {
           foreach(var i in lst)
            {
                if(i.GetName().Equals(colleague.GetName()))
                {
                    i.ReceiveNotification(amount);
                }
            }
        }
    }
}
