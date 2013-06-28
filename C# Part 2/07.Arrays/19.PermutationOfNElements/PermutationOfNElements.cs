using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter quantity of digits? ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("How many digits in a variation? ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int i = 0, j = 1; i < n; i++, j++)
        {
            array[i] = j;
        }

        int[] result = new int[k];

        for (int variations = 0; variations < n*k; variations++)
		{
			for (int i = 1; i <= n; i++)
            {
                for (int j = 0 ; j < k; j++)
                {
                    if (i == j) continue;
                    else
                    {
                        result[j] = array[j];
                    }
                }

                for (int j = 0; j < k; j++)
                {
                    Console.Write(result[j]);
                }
                Console.WriteLine();
            } 
		}
    }
}

