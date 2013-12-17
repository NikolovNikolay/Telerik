/*Write a recursive program for generating and printing all the combinations with duplicates of k elements from n-element set.*/

namespace CombinationsWithoutRepet
{
    using System;
    using System.Linq;

    class CombinationsWithoutRepeat
    {
        static void Main(string[] args)
        {
            Console.Write("Input quantity of elements:");
            int elementsInCombination = int.Parse(Console.ReadLine());
            Console.Write("Input elements in a combination (int must be greater or equal to {0}): ", elementsInCombination);
            int elementsQuantity = int.Parse(Console.ReadLine());

            GenerateCombinations(new int[elementsInCombination], 0, 1, elementsQuantity);
        }

        private static void GenerateCombinations(int[] array, int index, int start, int end)
        {
            if (index >= array.Length)
            {
                Console.WriteLine("(" + String.Join(", ", array) + ")");
                return;
            }

            for (int i = start; i <= end; i++)
            {
                array[index] = i;
                GenerateCombinations(array, index + 1, i + 1, end);
            }
        }
    }
}
