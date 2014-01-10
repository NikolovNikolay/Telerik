
namespace ImplementHashSet
{
    using System;
    using System.Collections.Generic;
    using ImplementHashTable;

    public class HashedSet<T>
    {
        private HashTable<T, int> hashTable;
        private static Random generator = new Random();

        public HashedSet()
        {
            this.hashTable = new HashTable<T, int>();
        }

        public int Count
        {
            get
            {
                return this.hashTable.Count;
            }
        }

        public ICollection<T> Keys
        {
            get
            {
                return this.hashTable.Keys;
            }
        }

        public void Add(T value)
        {
            this.hashTable.Add(value, generator.Next());
        }

        public void Remove(T value)
        {
            this.hashTable.Remove(value);
        }

        public void Find(T value)
        {
            this.hashTable.Find(value);
        }

        public void Clear()
        {
            this.hashTable.Clear();
        }

        public void Union(HashedSet<T> setToUnionWith)
        {
            foreach (var key in setToUnionWith.Keys)
            {
                if(!this.hashTable.ContainsKey(key))
                {
                    this.hashTable.Add(key, generator.Next());
                }
            }
        }

        public void Intersect(HashedSet<T> setToIntersectWith)
        {
            foreach (var key in setToIntersectWith.Keys)
            {
                if(this.hashTable.ContainsKey(key))
                {
                    this.hashTable.Remove(key);
                }
            }
        }
    }
}
