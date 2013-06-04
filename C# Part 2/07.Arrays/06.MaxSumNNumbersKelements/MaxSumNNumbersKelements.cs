/*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
*/

using System;

class MaxSumNNumbersKelements
{
    static void Main()
    {
        Console.Write("Enter the array's length: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number of elements: ");
        int k = int.Parse(Console.ReadLine());
        if (n < k)
        {
            Console.WriteLine("Input correct value for k");
            return;
        }
        string currentSeq = string.Empty;
        int sum = 0;
        string bestSeq = string.Empty;
        int bestSum = int.MinValue;

        int[] array = new int[n];
        int arrayLength = array.Length;
        Console.WriteLine("Input numbers:");

        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        if (n == k)
        {
            Console.Write("Best sequance is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
                sum += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Best sum is {0}", sum);
        }
        else if (n > k)
        {
             for (int i = 0; i < arrayLength; i++)
            {
                currentSeq = string.Empty;

                if (i + k > arrayLength)
                {
                    break;
                }
                for (int j = i; j < i+k; j++)
			    {
                    sum = sum + array[j];
                    currentSeq = currentSeq + ' ' + array[j];
                    if (sum > bestSum)
                    {
                        bestSum = sum;
                        bestSeq = currentSeq;
                    }
                    
			    }
                sum = 0;
            }
             Console.Write("The sequence of numbers with Max sum is: {0}",bestSeq);
             Console.WriteLine();
             Console.WriteLine("Max sum = {0}",bestSum);
        }
    }
}
//1. ako k>n, vuvedete corekten k
//2. ako k=n, bestSeq = celiq masiv i bestSum= sumata na celiq masiv
//3. 