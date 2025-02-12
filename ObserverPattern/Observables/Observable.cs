using ObserverPattern.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observables
{
    class Observable : IObservable
    {
        List<INotifyObserver> list = [];
        int stockCount = 0;
        public void Add(INotifyObserver observer)
        {
            list.Add(observer);
        }

        public int GetData()
        {
            return stockCount;
        }

        public void Notify()
        {
            foreach(INotifyObserver notify in list)
            {
                notify.Update();
            }
        } 
        public void Remove(INotifyObserver observer)
        {
            list.Remove(observer);
        }

        public void SetData(int data)
        {
            if (stockCount == 0)
                Notify();
            stockCount += data;
        }

    }
}
