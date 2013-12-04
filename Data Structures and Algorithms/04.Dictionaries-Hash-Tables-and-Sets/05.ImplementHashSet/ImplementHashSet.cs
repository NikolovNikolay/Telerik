/*Implement the data structure "set" in a class HashedSet<T> 
 * using your class HashTable<K,T> to hold the elements. 
 * Implement all standard set operations like Add(T), Find(T),
 * Remove(T), Count, Clear(), union and intersect.
*/

namespace ImplementHashSet
{
    using System;
    using System.Collections.Generic;
    using ImplementHashTable;

    class ImplementHashSet
    {
        static void Main()
        {
            var a = new HashedSet<string>();
            a.Add("ha");
            a.Add("ho");

            var b = new HashedSet<string>();
            b.Add("bla");
            b.Add("bah");

            a.Union(b);

            var c = new HashedSet<string>();
            c.Add("ha");

            a.Intersect(c);

            foreach (var item in a.Keys)
            {
                Console.WriteLine(item);
            }
         }
    }
}
