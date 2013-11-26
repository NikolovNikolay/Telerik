/*Write a method that finds the longest subsequence of equal numbers in given List<int>
 * and returns the result as new List<int>. Write a program to test whether the method 
 * works correctly.
*/

namespace LongestSubsequenceOfEqualNumbers
{
    using System;
    using System.Collections.Generic;

    class LongestSubsequenceOfEqualNumbers
    {
        static void Main()
        {
            var numbers = new List<int> { 1, 4, 5, 6, 6, 6, 8, 1, 0, 45, 11, 89, 4, 8,8,8, 8, 10, 10, 10, 10, 10 };

            var result = FindLongesSequenceOfEqualNumbers(numbers);

            foreach (var item in result)
            {
                Console.Write("{0} ", item);
            }
        }

        private static List<int> FindLongesSequenceOfEqualNumbers(List<int> list)
        {
            list.Add(0);
            int[] resultData = new int[3];

            int startIndex = 0;
            int equals = 1;

            for (int i = 1; i < list.Count - 1; i++)
            {
                if(list[i] != list[i-1])
                {
                    equals = 0;
                }

                equals++;

                if(equals > resultData[2])
                {
                    resultData[2] = equals;
                    resultData[0] = i - equals + 1;
                }

            }

            var result = list.GetRange(resultData[0], resultData[2]);
            return result;
        }
    }
}
