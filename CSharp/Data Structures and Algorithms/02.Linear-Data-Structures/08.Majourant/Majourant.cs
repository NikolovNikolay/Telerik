/** The majorant of an array of size N is a value that occurs in 
 * it at least N/2 + 1 times. Write a program to find the majorant
 * of given array (if exists). Example:
{2, 2, 3, 3, 2, 3, 4, 3, 3}  3
*/

namespace Majourant
{
    using System;
    using System.Collections.Generic;

    class Majourant
    {
        static void Main()
        {
            // abstract entry point (hard to achieve n/2 +1 occurences, because array is randomly filled)
            //Console.WriteLine("Input arry's length:");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //FillArray(array);

            // hardcoded entry point
            int[] array = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            int majourant = array.Length / 2 + 1;

            for (int index = 0; index < array.Length; index++)
            {
                if(dictionary.ContainsKey(array[index]))
                {
                    dictionary[array[index]]++;
                }
                else
                {
                    dictionary.Add(array[index], 1);
                }
            }

            bool majourantAvailable = false;
            int majourantValue = 0;
            foreach (var item in dictionary)
            {
                if(item.Value >= majourant)
                {
                    majourantAvailable = true;
                    majourantValue = item.Key;
                }
            }

            if(majourantAvailable)
            {
                Console.WriteLine("Majourant: {0}", majourantValue);
            }
            else
            {
                Console.WriteLine("Majourant not available.");
            }
        }

        private static void FillArray(int[] array)
        {
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1,26);
            }
        }
    }
}
