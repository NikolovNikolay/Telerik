using System;
using System.Linq;

namespace Delegate
{
    public delegate void Greet(string greeting);
    public class Timer
    {
        public void PrintGreeting(string greeting)
        {
            Console.WriteLine("Said: {0} at {1}",greeting, DateTime.Now);
        }
    }
}
