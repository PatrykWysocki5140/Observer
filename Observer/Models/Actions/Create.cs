using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models.Actions
{
    internal class CreateAction : Observer.Observer
    {
        public override void Notify(string eventName, object eventValue)
        {
            Console.WriteLine("notify: Create User, " + ((Actor.Actor)eventValue).Id + "!");
        }
    }
}
