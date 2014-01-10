
namespace LinkedListImplementation
{
    using System;
    using System.Collections.Generic;

    public class LinkedList<T>
    {
        private ListItem<T> firstElement;
        private int count = 0;

        public LinkedList()
        {
        }

        public T this[int index]
        {
            get
            {
                ListItem<T> currentNode = this.firstElement;
                int counter = 0;

                while (counter != index)
                {
                    currentNode = currentNode.Next;
                    counter++;
                }

                return currentNode.Value;
            }
        }

        public ListItem<T> First
        {
            get { return this.firstElement; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public void AddFirst(T value)
        {
            if(this.firstElement == null)
            {
                this.firstElement = new ListItem<T>(value);
                this.count++;
            }
            else
            {
                ListItem<T> newListItem = new ListItem<T>(value);

                newListItem.Next = this.firstElement;
                this.firstElement = newListItem;
                this.count++;
            }
                
        }

        public void AddLast(T value)
        {
            if(this.firstElement == null)
            {
                this.firstElement = new ListItem<T>(value);
                this.count++;
            }
            else
            {
                ListItem<T> newNode = this.firstElement;

                while (newNode.Next != null)
                {
                    newNode = newNode.Next;
                }

                newNode.Next = new ListItem<T>(value);
                this.count++;
            }
        }
    }
}
