using System;

class SortNumbersInAnArray
{
    static void Main()
    {
        Console.Write("Enter array's length: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        int min = 0;

        Console.WriteLine("Enter numbers: ");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            min = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[min])
                {
                    min = j;
                }
            }

            if (min != i)
            {
                int temp = 0;
                temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }
        }
        Console.Write("The sorted array is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
    }
}

