using System;
using System.Linq;

namespace Events
{
    public class CustomEvent : EventArgs
    {
        private string message;

        public CustomEvent(string s)
        {
            message = s;
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
