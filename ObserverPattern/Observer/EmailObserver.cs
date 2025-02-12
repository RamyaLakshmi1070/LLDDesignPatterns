using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    class EmailObserver<T> : INotifyObserver
    {
        T emails;
        IObservable _observable;
        public EmailObserver(T email,IObservable observable )
        {
            emails = email;
            _observable = observable;
        }
        public void Update()
        {
            if(_observable.GetData()==0)
            Console.WriteLine("Alert Stock is refilled {0}" ,emails);
        }
    }
}
