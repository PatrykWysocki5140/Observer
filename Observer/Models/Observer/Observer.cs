

namespace Observer.Models.Observer
{
    internal abstract class Observer
    {
        public abstract void Notify(string eventName, object eventValue);
    }
}
