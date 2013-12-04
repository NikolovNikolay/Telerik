/*Implement the data structure "hash table" in a class HashTable<K,T>.
 * Keep the data in array of lists of key-value pairs
 * (LinkedList<KeyValuePair<K,T>>[]) with initial capacity of 16.
 * When the hash table load runs over 75%, perform resizing to 2 times 
 * larger capacity. Implement the following methods and properties:
 * Add(key, value), Find(key)value, Remove( key), Count, Clear(), this[], Keys.
 * Try to make the hash table to support iterating over its elements with foreach.
*/

namespace ImplementHashTable
{
    using System;
    using System.Collections.Generic;

    class ImplementHashTable
    {
        static void Main()
        {
            try
            {
                HashTable<string, int> a = new HashTable<string, int>();

                a.Add("3", 5);
                a.Add("3", 6);
                a.Add("ab", 7);
                a.Add("ac", 8);
                
                Console.WriteLine(a["3"]);
                a.Remove("3");
                var abc = a.Keys;

                foreach (var item in a)
                {
                    Console.WriteLine("{0} -> {1}",item.Key,item.Value);
                }
                a.Clear();
                Console.WriteLine(a.Find("a"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
