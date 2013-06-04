/** Write a program that sorts an array of integers
 * using the merge sort algorithm (find it in Wikipedia).
 */

using System;

class MergeSortAlgorithm
{
    static void Main()
    {
        // creation and print of an unsorted array
        Console.Write("Quantity of numbers in array: ");
        int N = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int[] unsortedArray = new int[N];

        for (int i = 0; i < unsortedArray.Length; i++)
        {
            unsortedArray[i] = randomGenerator.Next(-100, 101);
        }

        for (int i = 0; i < unsortedArray.Length; i++)
        {
            Console.Write(" {0}", unsortedArray[i]);
        }
        Console.WriteLine();

        // sorting the array, using the merge-sort method
        MergeSort(unsortedArray, 0, unsortedArray.Length - 1);

        // printing the sorted array
        for (int i = 0; i < unsortedArray.Length; i++)
        {
            Console.Write(" {0}", unsortedArray[i]);
        }
        Console.WriteLine();
    }

    public static void MergeMethod(int[] numbers, int left, int middle, int right)
    {
        int[] temp = new int[25];
        int i, left_end, num_elements, tmp_pos;
        left_end = middle - 1;
        tmp_pos = left;
        num_elements = right - left + 1;

        while ((left <= left_end) && middle <= right)
        {
            if (numbers[left] <= numbers[middle])
            {
                temp[tmp_pos++] = numbers[left++];
            }
            else
            {
                temp[tmp_pos++] = numbers[middle++];
            }
        }
        while (left <= left_end)
        {
            temp[tmp_pos++] = numbers[left++];
        }

        while (middle <= right)
        {
            temp[tmp_pos++] = numbers[middle++];
        }

        for (i = 0; i < num_elements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
        
    }

    static public void MergeSort(int[] numbers, int left, int right)
    {
        int middle;

        if (right > left)
        {
            middle = (right + left) / 2;
            MergeSort(numbers, left, middle);
            MergeSort(numbers, (middle + 1), right);

            MergeMethod(numbers, left, (middle + 1), right);
        }
    }
}

