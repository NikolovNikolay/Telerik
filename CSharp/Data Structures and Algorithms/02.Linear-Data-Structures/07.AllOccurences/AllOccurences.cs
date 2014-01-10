/*Write a program that finds in given array of integers 
 * (all belonging to the range [0..1000]) how many times each of them occurs.
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
*/

namespace AllOccurences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AllOccurences
    {
        static void Main(string[] args)
        {
            int[] array = new int[1000];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            FillArray(array);
            GetOccurencesToDictionary(dictionary, array);

            var buffer = dictionary.Keys.ToList();
            buffer.Sort();

            foreach (var item in buffer)
            {
                Console.WriteLine("{0} -> {1}", item, dictionary[item]);
            }

        }

        private static void FillArray(int[] array)
        {
            int length = array.Length;
            Random rand = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rand.Next(1, 26);
            }
        }

        private static void GetOccurencesToDictionary(Dictionary<int,int> dictionary, int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                if (dictionary.ContainsKey(array[index]))
                {
                    dictionary[array[index]]++;
                }
                else
                {
                    dictionary.Add(array[index], 1);
                }
            }
        }
    }
}
