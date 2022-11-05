using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models.Actions
{
    internal class SendInfoAction : Observer.Observer
    {
        public override void Notify(string eventName, object eventValue)
        {
            if (eventName == Actors.ACTOR_CREATE)
            {
                Console.WriteLine("Notify: ACTOR_CREATE, sending info to main instance about: " + ((Actor.Actor)eventValue).Name);
            }
            else if (eventName == Actors.ACTOR_DELETE)
            {
                Console.WriteLine("Notify: ACTOR_DELETE, sending info to main instance about: " + ((Actor.Actor)eventValue).Name);
            }
        }
    }
}
