using System;
using System.Linq;

namespace Events
{
    public class Subscriber
    {
        private string id;
        public Subscriber(string ID, Publisher pub)
        {
            this.id = ID;
            pub.RaiseCustomEvent += HandleCustomEvent;
        }

        void HandleCustomEvent(object sender, CustomEvent e)
        {
            Console.WriteLine(id + " received: {0}", e.Message);
        }
    }
}
