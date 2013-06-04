
using System;

class MaximalSumInArray
{
    static void Main()
    {
        Console.Write("Length? ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Numbers to sum? ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int sum = 0;
        int maxSum = 0;
        string sequence = string.Empty;
        string bestSequence = string.Empty;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Value {0}: ", i+1);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("{");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(" {0} ", array[i]);
        }
        Console.Write("}");
        Console.WriteLine();
        for (int i = 0; i < array.Length; i++)
        {
            sum = 0;
            sequence = string.Empty;
            if (i + k > array.Length)
            {
                break;
            }

            for (int j = i; j < i+k; j++)
            {

                sum = sum+ array[j];
                sequence = sequence + ' ' + array[j];
                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestSequence = sequence;
                }
            }
        }
        Console.WriteLine("The best sequence is: {0}", bestSequence);
        Console.WriteLine("The maximum sum is: {0}", maxSum);
    }
    
}


