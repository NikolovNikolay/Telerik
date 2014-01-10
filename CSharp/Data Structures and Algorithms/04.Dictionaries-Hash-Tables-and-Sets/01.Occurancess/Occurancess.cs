/*Write a program that counts in a given array of double
 * values the number of occurrences of each value.
 * Use Dictionary<TKey,TValue>.
*/

namespace Occurancess
{
    using System;
    using System.Collections.Generic;

    class Occurancess
    {
        static void Main()
        {
            double[] array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            IDictionary<double, int> occurances = new SortedDictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                if(!occurances.ContainsKey(array[i]))
                {
                    occurances.Add(array[i], 1);
                }
                else
                {
                    occurances[array[i]]++;
                }
            }

            foreach (var item in occurances)
            {
                Console.WriteLine("{0} -> {1}", item.Key,item.Value);
            }

        }
    }
}
