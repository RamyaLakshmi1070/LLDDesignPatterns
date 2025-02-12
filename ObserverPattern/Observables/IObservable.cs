using ObserverPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observables
{
    interface IObservable
    {
        public void Add(INotifyObserver observer);
        public void Remove(INotifyObserver observer);
        public void Notify();
        public void SetData(int data);
        public int GetData();

    }
}
