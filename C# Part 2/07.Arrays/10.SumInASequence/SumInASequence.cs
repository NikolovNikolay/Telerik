using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumInASequence
{
    static void Main()
    {
        Console.Write("Search for sum: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        string sequence = string.Empty;
        StringBuilder sequenceBuild = new StringBuilder();
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
        int[] arr = new int[15];
        Random generator = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = generator.Next(0, 15);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(" {0} ",arr[i]);
        }
        Console.WriteLine();
        Console.WriteLine("The existing sequences, which sum is {0} are: ", n);
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j < arr.Length; j++)
            {
                sum = sum + arr[j];
                sequence = string.Empty;
                sequenceBuild.AppendFormat("{0}, ", arr[j]);
                if (sum > n)
                {
                    sequenceBuild.Clear();
                    sum = 0;
                    break;
                }
                if (sum == n)
                {
                    sequence = sequenceBuild.ToString();
                    Console.Write(sequence);
                    Console.WriteLine();
                }
            }

        }
    }
}
