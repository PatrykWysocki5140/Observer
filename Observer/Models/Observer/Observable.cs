

namespace Observer.Models.Observer
{
    internal abstract class Observable
    {
        protected Dictionary<Observer, string> _observers = new Dictionary<Observer, string>();

        public void CreateObservable(Observer observer, string? eventName = null)
        {
            _observers.Add(observer, eventName);
        }

        public void DeleteObservable(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservable(string eventName, object eventValue)
        {
            foreach (Observer key in _observers.Keys)
            {
                if (_observers[key] == eventName)
                {
                    key.Notify(eventName, eventValue);
                }
            }
        }
    }
}
