/*Write a program that reads a sequence of integers (List<int>)
 * ending with an empty line and sorts them in an increasing order.
*/

namespace SortListOfIntegers
{
    using System;
    using System.Collections.Generic;

    class SortListOfIntegers
    {
        static void Main()
        {
            var list = new List<int>();

            Console.WriteLine("Input some random integers:");
            FillList(list);

            list.Sort();

            Console.WriteLine("Sorted sequence:");
            PrintSortedList(list);
        }

        public static void FillList(List<int> list)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    return;
                }
                else
                {
                    list.Add(int.Parse(input));
                }
            }
        }

        public static void PrintSortedList(List<int> list)
        {
            foreach (var integer in list)
            {
                Console.Write("{0} ", integer);
            }
            Console.WriteLine();
        }
    }
}
