/*Write a program that removes from given sequence all negative numbers.
*/

namespace RemoveNegativeNumbers
{
    using System;
    using System.Collections.Generic;

    class RemoveNegativeNumbers
    {
        static void Main()
        {
            List<int> numbers = new List<int> { -1, 2, -3, 4, -5, 6, -7, 8, -9, 10 };

            for (int index = 0; index < numbers.Count; index++)
            {
                if(numbers[index] < 0)
                {
                    numbers.RemoveAt(index);
                    index--;
                }
            }

            foreach (var number in numbers)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();
        }
    }
}
