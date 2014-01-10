/*Implement the ADT queue as dynamic linked list. Use generics
 * (LinkedQueue<T>) to allow storing different data types in the queue.
*/
namespace ADTQueue
{
    using System;
    using System.Collections.Generic;

    class ADTQueue
    {
        static void Main()
        {
            LinkedQueue<int> qu = new LinkedQueue<int>();
            qu.Enqueue(45);
            qu.Enqueue(90);
            qu.Enqueue(23);


            for (int i = 0; i < qu.Count; i++)
            {
                Console.WriteLine(qu[i]);
            }

            Console.WriteLine();
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine();

            for (int i = 0; i < qu.Count; i++)
            {
                Console.WriteLine(qu[i]);
            }


            Console.WriteLine();
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine();

            for (int i = 0; i < qu.Count; i++)
            {
                Console.WriteLine(qu[i]);
            }
        }
    }
}
