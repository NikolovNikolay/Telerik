using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumInASequence
{
    static void Main()
    {
        // Find sum in a sequence of numbers 

        int[] array = { 4, 3, 1, 4, 2, 5, 8 };
        Console.WriteLine("Enter desired sum");
        int s = int.Parse(Console.ReadLine());
        int count = 0;
        int sum = 0;
        string elements = string.Empty;

        for (int i = 0; i < array.Length; i++)
        {
            sum = 0;
            for (int j = i; j < array.Length; j++)
            {
                sum = sum + array[j];
                elements = elements + " " + array[j];

                if (sum == s)
                {
                    Console.WriteLine(elements);
                    count++;
                    elements = string.Empty;
                    sum = 0;

                }
                if (sum > s)
                {
                    elements = string.Empty;
                    sum = 0;
                    break;
                }
            }
        }

        if (count == 0)
        {
            Console.WriteLine("There is no sequence, forming that sum!");
        }

        /* Find sum, formed by any number*/

        //Console.WriteLine("Enter the wanted sum of the subsets:");
        //long wantedSum = long.Parse(Console.ReadLine());
        //Console.WriteLine("Enter the number of elements:");
        //long numberOfElements = long.Parse(Console.ReadLine());
        //long[] elements = new long[numberOfElements];
        //int counter = 0;
        //string subset = string.Empty;

        //for (int i = 0; i < elements.Length; i++)
        //{
        //    Console.WriteLine("Enter element № {0}", i + 1);
        //    elements[i] = long.Parse(Console.ReadLine());
        //}

        //int maxSubsets = (int)Math.Pow(2, numberOfElements);
        //for (int i = 1; i < maxSubsets; i++)
        //{
        //    subset = string.Empty;
        //    long checkingSum = 0;
        //    for (int j = 0; j <= numberOfElements; j++)
        //    {
        //        //int mask = 1 << j;
        //        //int nAndMask = i & mask;
        //        //int bit = nAndMask >> j;
        //        if (((i>>j) & 1) == 1)
        //        {
        //            checkingSum = checkingSum + elements[j];
        //            subset = subset + " " + elements[j];
        //        }
        //    }

        //    if (checkingSum == wantedSum)
        //    {
        //        Console.WriteLine("Number of subest that have the sum of {0}", wantedSum);
        //        counter++;
        //        Console.WriteLine("This subset has a sum of {0} : {1} ", wantedSum, subset);
        //    }
        //}

        //Console.WriteLine(counter);
    }
}
