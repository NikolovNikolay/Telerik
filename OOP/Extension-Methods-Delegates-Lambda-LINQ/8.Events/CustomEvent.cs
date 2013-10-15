using System;
using System.Linq;

namespace Events
{
    public class CustomEvent : EventArgs
    {
        private string message;

        public CustomEvent(string s)
        {
            this.message = s;
        }

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }
    }
}
