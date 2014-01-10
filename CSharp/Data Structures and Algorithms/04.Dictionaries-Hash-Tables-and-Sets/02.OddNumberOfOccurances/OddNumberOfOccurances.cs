/*Write a program that extracts from a given sequence of
 * strings all elements that present in it odd number of
 * times. Example:
        {C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}
*/

namespace OddNumberOfOccurances
{
    using System;
    using System.Collections.Generic;

    class OddNumberOfOccurances
    {
        static void Main()
        {
            string[] sequences = new string[] {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            IDictionary<string, int> occurances = new SortedDictionary<string,int>();

            for (int i = 0; i < sequences.Length; i++)
            {
                if(occurances.ContainsKey(sequences[i]))
                {
                    occurances[sequences[i]]++;
                }
                else
                {
                    occurances.Add(sequences[i], 1);
                }
            }

            foreach (var occurance in occurances)
            {
                if(occurance.Value % 2 != 0)
                {
                    Console.WriteLine(occurance.Key);
                }
            }
        }
    }
}
