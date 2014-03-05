/*Implement the data structure "hash table" in a class HashTable<K,T>.
 * Keep the data in array of lists of key-value pairs (LinkedList<KeyValuePair<K,T>>[])
 * with initial capacity of 16. When the hash table load runs over 75%, perform resizing
 * to 2 times larger capacity. Implement the following methods and properties:
 * Add(key, value), Find(key)value, Remove( key), Count, Clear(), this[], Keys.
 * Try to make the hash table to support iterating over its elements with foreach.
*/

namespace HashTableImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HashTable;

    public class HashTableImplementation
    {
        public static void Main()
        {
            HashTable<string, int> table = new HashTable<string, int>();

            table.Add("pesho", 1);
            table.Add("Radko", 3);
            table.Add("kiro", 56);
            table.Add("miro", 78);
            table.Add("sasa", 98);
            table.Add("jijo", 445);
            table.Add("Nikolay", 2);
            table.Add("Gecata", 34);
            table.Add("marto", 475);
            table.Add("gogo", 1);
            table.Add("tinkata", 69);
            table.Add("pedro", 0);
            table.Add("pesho", 2);
            table.Add("Radko", 3);

            Console.WriteLine(table.Find("jijo"));
            Console.WriteLine(table.Find("marto"));
            Console.WriteLine(table.Find("popov"));

            Console.WriteLine(table.Count);
            table.Remove("miro");
            Console.WriteLine(table.Count);

            Console.WriteLine(table["marto"]);
            table["marto"] = 600;
            Console.WriteLine(table["marto"]);
            table["nikitobe"] = 1989;
            Console.WriteLine(table["nikitobe"]);
            


            foreach (var elmnt in table)
            {
                Console.WriteLine(elmnt.Key);
            }

            table.Clear();
            Console.WriteLine(table.Count);
        }
    }
}
