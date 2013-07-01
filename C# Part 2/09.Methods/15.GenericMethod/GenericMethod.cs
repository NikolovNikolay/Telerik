using System;

class GenericMethod
{
    static void Main()
    {
        //int[] arrayOfIntegers = { 8, 4, -7, 2, 9, -12, 56, -1};
        Console.WriteLine("Minimal element is: {0}", ReturnMinimal(13.1, 10.12, 3.2, -6, 98, 12, 4, 7, 2));
        Console.WriteLine("Maximal element is: {0}", ReturnMaximal(13, 10, 3, -6, 98, 12, 4, 7, 2));
        Console.WriteLine("The sum of elements is: {0}", SumElementsInArray(13, 10, 3, -6, 98, 12, 4, 7, 2));
        Console.WriteLine("The product of elements is: {0}", ProductOfIntegers(13, 10, 3, -6, 98, 12, 4, 7, 2));
        Console.WriteLine("Average is: {0}", AverageElement(13, 10, 3, -6, 98, 12, 4, 7, 2));
    }

    public static T ReturnMinimal<T>(params T[] array)
    {
        dynamic minimal = int.MaxValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minimal) minimal = array[i];
        }
        return minimal;
    }

    public static T ReturnMaximal<T>(params T[] array)
    {
        dynamic maximal = int.MinValue;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maximal) maximal = array[i];
        }
        return maximal;
    }

    public static T SumElementsInArray<T>(params T[] array)
    {
        dynamic sum = 0;

        for (int i = 0; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }

    public static T ProductOfIntegers<T>(params T[] array)
    {
        dynamic product = 1;

        for (int i = 0; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }

    public static T AverageElement<T>(params T[] array)
    {
        int elements = array.Length;
        dynamic sum = 0;
        for (int i = 0; i < elements; i++)
        {
            sum += array[i];
        }

        dynamic average = (sum / elements);
        return average;
    }
}
