using System;

class FirstDigitBiggerThanNeighbours
{
    static int FirstBiggerThanNeighbours(int[] array)
    {
        int index = 1;

        for (int i = 1; i < array.Length -1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1])
            {
                index = i;
                break;
            }
        }

        return index;
    }

    static void Main()
    {
        int[] array = new int[] { 5, 3, 6, 9, 10, 75, 8, 0, 23, 14, 1, 9, 8, 2, 44 };
        Console.WriteLine(FirstBiggerThanNeighbours(array));
    }
}
