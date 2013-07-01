using System;

class AddingTwoPositiveIntegers
{
    static void Main()
    {
        int[] firstArray = { 3, 4, 5, 7, 8, 9 , 8, 4, 7 };
        int[] secondArray = { 1, 7, 9, 0, 2, 5, 4 };
        AddingDigits(firstArray, secondArray);
    }

    static void AddingDigits(int[] arrayOne, int[] arrayTwo)
    {
        int length = 1;

        if (arrayOne.Length > arrayTwo.Length)
        {
            length += arrayOne.Length;
        }

        if (arrayTwo.Length > arrayOne.Length)
        {
            length += arrayTwo.Length;
        }

        int[] result = new int[length];

        for (int index = 0; index < length; index++)
        {
            if (index < arrayOne.Length)
            {
                result[index] += arrayOne[index];
                if (result[index] >= 10)
                {
                    result[index] -= 10;
                    result[index + 1] += 1;
                }
            }

            if (index < arrayTwo.Length)
            {
                result[index] += arrayTwo[index];
                if (result[index] >= 10)
                {
                    result[index] -= 10;
                    result[index + 1] += 1;
                }
            }
        }

        Array.Reverse(result);
        PrintArray(result);
    }

    private static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i != 0)
            {
                Console.Write(array[i] + " ");
            }
            if (i == 0 && array[i] == 0)
            {
                continue;
            }
        }
        Console.WriteLine();
    }
}
