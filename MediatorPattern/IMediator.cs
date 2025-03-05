using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    interface IMediator
    {
        void Add(IColleague colleague);
        void PlaceBid(IColleague colleague,int amount);
    }
}
