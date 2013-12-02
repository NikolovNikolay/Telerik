/*Write a program that removes from given sequence all numbers that occur odd number of times. Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2}  {5, 3, 3, 5}
*/

namespace RemoveElementOddTimes
{
    using System;
    using System.Collections.Generic;

    class RemoveElementOddTimes
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };

            for (int index = 0; index < numbers.Count; index++)
            {
                int currentNumber = numbers[index];
                int counter = 0;
                List<int> repeatIndexes = new List<int>();
                for (int internalStart = 0; internalStart < numbers.Count; internalStart++)
                {
                    if(numbers[internalStart] == currentNumber)
                    {
                        counter++;
                        repeatIndexes.Add(internalStart);
                    }
                }

                if(counter % 2 != 0)
                {
                    numbers.RemoveAt(repeatIndexes[0]);
                    for (int i = 1; i < repeatIndexes.Count; i++)
                    {
                        numbers.RemoveAt(repeatIndexes[i] - i);
                    }
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
