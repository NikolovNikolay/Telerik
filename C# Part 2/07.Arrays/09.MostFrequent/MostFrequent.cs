using System;
using System.Text;

public class SequenceByGivenSum
{
    public static void Main()
    {
        int[] array = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3, 5, 5, 5, 5, 5, 5, 5, 7, 7, 7, 9, 10 };

        int mostFrequentElement = 0;
        int count = 0;
        int maxCount = 0;

        for (int i = 0; i < array.Length; i++)
        {
            count = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    count++;
                }
            }

            if (count > maxCount)
            {
                maxCount = count;
                mostFrequentElement = array[i];
            }
        }

        Console.WriteLine("{0} ({1} times)", mostFrequentElement, maxCount);
    }
}