/* 7. Using delegates write a class Timer that has can execute certain method at each t seconds.
*/

using System;
using System.Linq;
using System.Threading;

namespace Delegate
{
    class Program
    {
        public delegate void Greet(string greeting);

        static void Main()
        {
            Console.Write("Input t (seconds): ");
            int t = int.Parse(Console.ReadLine());
            Timer timer = new Timer();

            Greet greeting = new Greet(timer.PrintGreeting);

            while (true)
            {
                greeting("Hello");
                Thread.Sleep(t * 1000);
            }
        }
    }
}
