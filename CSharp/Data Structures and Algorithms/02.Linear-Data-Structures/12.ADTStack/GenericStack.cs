
namespace ADTStack
{
    using System;
    using System.Collections.Generic;

    public class GenericStack<T>
    {
        private const int DefaultSize = 5;
        private T[] stackArray;
        private int size;
        private int allElements;
        private int elementIndex = -1;

        public GenericStack()
        {
            this.size = DefaultSize;
            this.stackArray = new T[this.size];
        }
        
        public GenericStack(int size)
        {
            this.size = size;
            this.stackArray = new T[this.size];
        }

        public T this[int index]
        {
            get
            {
                return this.stackArray[index];
            }
        }

        public int AllElements
        {
            get { return this.allElements; }
        }

        public void Push(T value)
        {
            if(this.allElements == this.size - 1)
            {
                IncreaseSize();
            }

            this.allElements++;
            this.elementIndex++;
            this.stackArray[this.elementIndex] = value;
        }

        public T Pop()
        {
            T popElement = this.stackArray[this.elementIndex];
            this.allElements--;
            this.elementIndex--;

            return popElement;
        }

        private void IncreaseSize()
        {
            T[] buffer = new T[this.size];
            Array.Copy(this.stackArray, buffer, this.size);
            this.stackArray = new T[this.size * 2];
            Array.Copy(buffer, this.stackArray, this.size);
            this.size *= 2;
        }
    }
}
