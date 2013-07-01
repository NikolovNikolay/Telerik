using System;

class SetOfIntegersCalculations
{
    static void Main()
    {
        int[] arrayOfIntegers = { 8, 4, -7, 2, 9, -12, 56, -1};
        Console.WriteLine("Minimal element is: {0}",ReturnMinimal(arrayOfIntegers));
        Console.WriteLine("Maximal element is: {0}", ReturnMaximal(arrayOfIntegers));
        Console.WriteLine("The sum of elements is: {0}", SumElementsInArray(arrayOfIntegers));
        Console.WriteLine("The product of elements is: {0}", ProductOfIntegers(arrayOfIntegers));
        Console.WriteLine("Average is: {0:F3}", AverageElement(arrayOfIntegers));
    }

    static int ReturnMinimal(int[] array)
    {
        int minimal = int.MaxValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                if (array[i] < minimal) minimal = array[i];
            }
            if (array[i] > array[i + 1])
            {
                if (array[i + 1] < minimal) minimal = array[i + 1];
            }
        }
        return minimal;
    }

    static int ReturnMaximal(int[] array)
    {
        int maximal = int.MinValue;

        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                if (array[i] > maximal) maximal = array[i];
            }
            if (array[i] < array[i + 1])
            {
                if (array[i + 1] > maximal) maximal = array[i + 1];
            }
        }
        return maximal;
    }

    static int SumElementsInArray(int[] array)
    {
        int sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    static int ProductOfIntegers(int[] array)
    {
        int product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    static decimal AverageElement(int[] array)
    {
        int elements = array.Length;
        int sum = 0;
        for (int i = 0; i < elements; i++)
        {
            sum += array[i];
        }

        decimal average = (decimal)sum / elements;
        return average;
    }
}
