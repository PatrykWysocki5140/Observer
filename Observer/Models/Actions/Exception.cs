using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Models.Actions
{
    internal class ExceptionAction : Observer.Observer
    {
        public override void Notify(string eventName, object eventValue)
        {
            Console.WriteLine("Notify Exception Message: " + eventValue.ToString());
        }
    }
}
