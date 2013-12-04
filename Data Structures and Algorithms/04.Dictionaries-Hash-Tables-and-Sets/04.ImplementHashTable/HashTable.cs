
namespace ImplementHashTable
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class HashTable<K,T> : IEnumerable<KeyValuePair<K,T>>
    {
        private LinkedList<KeyValuePair<K, T>>[] dataContainer;
        private const int ContainerInitialSize = 16;
        private int elementCount;
        private const double ResizeBound = 0.75;

        public HashTable()
        {
            this.dataContainer = new LinkedList<KeyValuePair<K, T>>[ContainerInitialSize];
            this.elementCount = 0;
        }
        #region Properties
        public int Count
        {
            get { return this.elementCount; }
        }

        public ICollection<K> Keys
        {
            get
            {
                List<K> keyContainer = new List<K>();
                foreach (var item in this.dataContainer)
                {
                    if (item != null)
                    {
                        keyContainer.Add(item.First.Value.Key);
                    }
                }

                return keyContainer;
            }
        } 
        #endregion

        // indexer
        public T this[K key]
        {
            get
            {
                int currHash = key.GetHashCode() % this.dataContainer.Length;
                if (currHash < 0)
                    currHash *= -1;

                foreach (var listItem in this.dataContainer[currHash])
                {
                    if (listItem.Key.Equals(key))
                        return listItem.Value;
                }

                throw new ArgumentException("No element with this key");
            }
        }

        #region Methods
        public void Add(K key, T value)
        {
            CalculateDataContainerLoad();
            int currentHashCode = key.GetHashCode() % dataContainer.Length;
            if (currentHashCode < 0)
                currentHashCode *= -1;
            if (this.ContainsKey(key))
            {
                Console.WriteLine("Key existst. New value \"{0}\" added", value);
            }

            var newPair = new KeyValuePair<K, T>(key, value);
            this.dataContainer[currentHashCode].AddLast(newPair);
            this.elementCount++;
        }

        public bool ContainsKey(K key)
        {
            int currHash = key.GetHashCode() % this.dataContainer.Length;
            if (currHash < 0)
            {
                currHash *= -1;
            }

            if (this.dataContainer[currHash] == null)
            {
                //throw new ArgumentNullException(key.ToString,"No suck key exists");
                this.dataContainer[currHash] = new LinkedList<KeyValuePair<K, T>>();
            }

            foreach (var listItem in this.dataContainer[currHash])
            {
                if (listItem.Key.Equals(key))
                {
                    return true;
                }
            }

            return false;
        }

        public T Find(K key)
        {
            return this[key];
        }

        public void Remove(K key)
        {
            int currHash = key.GetHashCode() % dataContainer.Length;
            if (currHash < 0)
                currHash *= -1;
            this.elementCount--;

            if (this.ContainsKey(key))
            {
                this.dataContainer[currHash].RemoveFirst();
                return;
            }

            throw new ArgumentException("No element with this key");
        }

        public void Clear()
        {
            this.dataContainer = new LinkedList<KeyValuePair<K, T>>[ContainerInitialSize];
            this.elementCount = 0;
        } 
        #endregion

        private void CalculateDataContainerLoad()
        {
            int tempCounter = 0;
            foreach (var item in this.dataContainer)
            {
                if (item != null) tempCounter++;
            }
            if (this.elementCount == (tempCounter * ResizeBound) && this.elementCount > 0)
            {
                this.dataContainer = ResizeDataContainer(this.dataContainer);
            }
        }

        private LinkedList<KeyValuePair<K, T>>[] ResizeDataContainer(LinkedList<KeyValuePair<K, T>>[] container)
        {
            var newDataContainer = new LinkedList<KeyValuePair<K, T>>[container.Length * 2];
            Array.Copy(container, newDataContainer, container.Length);

            return newDataContainer;
        }

        public IEnumerator<KeyValuePair<K, T>> GetEnumerator()
        {
            for (int i = 0; i < this.dataContainer.Length; i++)
            {
                if(this.dataContainer[i] != null)
                {
                    var next = this.dataContainer[i].First;
                    while (next != null)
                    {
                        yield return new KeyValuePair<K,T>(next.Value.Key, next.Value.Value);
                        next = next.Next;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
