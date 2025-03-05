using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    interface IColleague
    {
        void PlaceBid(int amount);
        void ReceiveNotification(int amount);
        String GetName();
    }
}
