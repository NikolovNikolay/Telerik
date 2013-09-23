using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericList<T>  where T: IComparable
    {
        private T[] mainArray;
        private int ind = 0;
        private int initialCapacity;

        public GenericList(int capacity)
        {
            this.mainArray = new T[capacity];
            this.initialCapacity = capacity;
        }

        // indexer
        public T this[int index]
        {
            get { return this.mainArray[index]; }
            set { this.mainArray[index] = value; }
        }

        public void AddElement(T element)
        {
            if (this.ind >= this.mainArray.Length)
            {
                // Implementing autogrow as required. The autogrow works like in stringbuilder - if the length becomes bigger than declared or by default
                // the capacity becomes twice as bigger
                //T[] bigger = new T[this.mainArray.Length * 2];

                // Implementing autogrow like a list, with one element at a time. This wil prevent unnecessary print of zeroes in method ToString();
                T[] bigger = new T[this.mainArray.Length +1];
                for (int i = 0; i < this.mainArray.Length; i++)
                {
                    bigger[i] = this.mainArray[i];
                }

                this.mainArray = bigger;
                this.mainArray[this.ind] = element;
                this.ind++;
            }
            else
            {
                this.mainArray[this.ind] = element;
                this.ind++;
            }
        }

        public int FindIndex(T valueOfElement)
        {
            int index = 0;
            for (int i = 0; i < this.mainArray.Length; i++)
            {
                if (this.mainArray[i].Equals(valueOfElement))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void Clear()
        {
            T[] cleared = new T[this.initialCapacity];
            this.mainArray = cleared;
        }

        public int GetLength()
        {
            return this.mainArray.Length;
        }

        public void AddElementAt(int index, T element)
        {
            if (index < this.mainArray.Length && index >= 0)
            {
                // Implementing autogrow as required. The autogrow works like in stringbuilder - if the length becomes bigger than declared or by default
                // the capacity becomes twice as bigger
                //T[] array = new T[this.mainArray.Length * 2];

                // Implementing autogrow like a list, with one element at a time. This wil prevent unnecessary print of zeroes in method ToString();
                T[] array = new T[this.mainArray.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    array[i] = this.mainArray[i];
                }

                array[index] = element;

                for (int i = index+1, oldIndex =index ; i < this.mainArray.Length + 1; i++,oldIndex++)
                {
                    array[i] = this.mainArray[oldIndex];
                }

                this.mainArray = array;
            }
            else if (index == this.mainArray.Length)
            {
                // Implementing autogrow as required. The autogrow works like in stringbuilder - if the length becomes bigger than declared or by default
                // the capacity becomes twice as bigger
                //T[] array = new T[this.mainArray.Length * 2];

                // Implementing autogrow like a list, with one element at a time. This wil prevent unnecessary print of zeroes in method ToString();
                T[] array = new T[this.mainArray.Length + 1];

                for (int i = 0; i < index; i++)
                {
                    array[i] = this.mainArray[i];
                }
                array[index] = element;
                this.mainArray = array;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The index given is outside the array");
            }
        }

        public void RemoveElementAt(int index)
        {
            if (index < this.mainArray.Length && index >= 0)
            {
                T[] array = new T[this.mainArray.Length - 1];

                for (int i = 0; i < index; i++)
                {
                    array[i] = this.mainArray[i];
                }

                for (int i = index; i < this.mainArray.Length -1; i++)
                {
                    array[i] = this.mainArray[i+1];
                }

                this.mainArray = array;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The index given is outside the array");
            }
        }

        public T Min()
        {
            dynamic leastElement = int.MaxValue;
            for (int i = 0; i < this.mainArray.Length; i++)
            {
                if (this.mainArray[i] < leastElement)
                {
                    leastElement = this.mainArray[i];
                }
            }

            return leastElement;
        }

        public T Max()
        {   
            dynamic biggestElement = int.MinValue;
            for (int i = 0; i < this.mainArray.Length; i++)
            {
                if (this.mainArray[i] > biggestElement)
                {
                    biggestElement = this.mainArray[i];
                }
            }

            return biggestElement;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in this.mainArray)
            {
                sb.AppendFormat("{0} ", item);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
