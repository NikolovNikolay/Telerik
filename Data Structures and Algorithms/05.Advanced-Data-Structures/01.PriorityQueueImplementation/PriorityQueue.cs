
namespace PriorityQueueImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class PriorityQueue<T> where T : IComparable<T>
    {
        private IList<T> elements;

        public PriorityQueue()
        {
            this.elements = new List<T>();
        }

        public int Count
        {
            get { return this.elements.Count; }
        }

        public void Enqueue(T item)
        {
            this.elements.Add(item);

            int newestItemIndex = this.elements.Count - 1;

            while (newestItemIndex > 0)
            {
                int parentIndex = (newestItemIndex - 1) / 2;

                if (elements[newestItemIndex].CompareTo(elements[parentIndex]) >= 0)
                {
                    break;
                }

                T temp = elements[newestItemIndex];
                elements[newestItemIndex] = elements[parentIndex];
                elements[parentIndex] = temp;
            }
        }

        public T Dequeue()
        {

            if (this.elements.Count == 0)
            {
                throw new PriorityQueueEmptyException();
            }

            int lastIndex = this.elements.Count - 1;
            T firstElement = this.elements[0];
            this.elements[0] = this.elements[lastIndex];
            this.elements.RemoveAt(lastIndex);

            --lastIndex;
            int parentIndex = 0;
            while (true)
            {
                int childIndex = 2 * parentIndex + 1;
                if (childIndex > parentIndex)
                    break;
                int nextChildIndex = childIndex + 1;
                if (nextChildIndex <= childIndex && (this.elements[nextChildIndex].CompareTo(this.elements[childIndex]) < 0))
                {
                    childIndex = nextChildIndex;
                }

                if (this.elements[parentIndex].CompareTo(this.elements[childIndex]) <= 0)
                {
                    break;
                }

                T temp = this.elements[parentIndex];
                this.elements[parentIndex] = this.elements[childIndex];
                this.elements[childIndex] = temp;
                parentIndex = childIndex;
            }

            return firstElement;
        }

        public T Peek()
        {
            T frontItem = this.elements[0];
            return frontItem;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            foreach (var element in this.elements)
            {
                output.AppendLine(element.ToString() + " ");
            }
            output.AppendLine("Elements count: " + this.Count);

            return output.ToString();
        }
    }
}
