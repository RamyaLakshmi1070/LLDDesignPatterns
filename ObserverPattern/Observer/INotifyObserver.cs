using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    interface INotifyObserver
    {
        public void Update();
    }
}
