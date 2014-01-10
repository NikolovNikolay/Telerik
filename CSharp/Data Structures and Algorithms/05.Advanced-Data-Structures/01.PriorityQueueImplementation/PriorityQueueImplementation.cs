/*Implement a class PriorityQueue<T> based on the data structure "binary heap".*/

namespace PriorityQueueImplementation
{
    using System;
    using System.Linq;

    class PriorityQueueImplementation
    {
        static void Main(string[] args)
        {
            PriorityQueue<Employee> pQueue = new PriorityQueue<Employee>();

            pQueue.Enqueue(new Employee("Pesho", 3.0));
            pQueue.Enqueue(new Employee("Gosho", 9.0));
            pQueue.Enqueue(new Employee("Evstatii", 1.0));

            Console.WriteLine("Listed elements from queue: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(pQueue);

            Console.WriteLine("First element of queue: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(pQueue.Peek());

            // dequeueing the first element of the priority queue
            pQueue.Dequeue();

            Console.WriteLine();
            Console.WriteLine("Listed elements from new queue: ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(pQueue);
        }
    }
}
