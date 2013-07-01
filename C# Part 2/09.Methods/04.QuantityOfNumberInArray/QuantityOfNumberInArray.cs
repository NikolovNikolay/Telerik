using System;

class QuantityOfNumberInArray
{
    static int CheckNumberInArray(int[] array, int number)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        int[] array = new int[] {1,5,6,9,8,7,4,5,2,3,6,5,2,1,7,8,9,6,5,2};

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i]+ " ");
        }
        Console.WriteLine();
        Console.Write("Pick a digit to check for its quantity: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine(CheckNumberInArray(array, number));
    }
}
