
namespace ADTQueue
{
    using System;
    using System.Collections.Generic;

    public class LinkedQueue<T>
    {
        private QueuedItem<T> head;
        private int count;

        public LinkedQueue()
        {
        }

        public T this[int index]
        {
            get
            {
                QueuedItem<T> currentItem = this.head;
                int counter = 0;

                while (counter != index)
                {
                    currentItem = currentItem.Next;
                    counter++;
                }

                return currentItem.Value;
            }
        }

        public int Count
        {
            get { return this.count; }
        }

        public T Dequeue()
        {
            var result = this.head.Value;
            this.head = this.head.Next;
            count--;

            return result;
        }



        public void Enqueue(T value)
        {
            if(this.head == null)
            {
                QueuedItem<T> newItem = new QueuedItem<T>(value);
                this.head = newItem;
                this.count++;
            }
            else
            {
                QueuedItem<T> newItem = this.head;

                while (newItem.Next != null)
                {
                    newItem = newItem.Next;
                }

                newItem.Next = new QueuedItem<T>(value);
                this.count++;
            }
        }
    }
}
