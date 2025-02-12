using ObserverPattern.Observer;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObservable obj1 = new Observable();
            INotifyObserver observer1 = new EmailObserver<String>("ray@gamil.com", obj1);
            INotifyObserver observer2 = new EmailObserver<String>("ray2@gamil.com", obj1);
            INotifyObserver observer3 = new EmailObserver<long>(8767892873, obj1);

            obj1.Add(observer1);
            obj1.Add(observer2);
            obj1.Add(observer3);

            obj1.SetData(100);

        }
    }
}
