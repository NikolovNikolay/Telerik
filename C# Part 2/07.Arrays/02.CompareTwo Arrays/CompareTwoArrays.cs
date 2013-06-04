/* Write a program that reads two arrays from the console and compares them element by element.
*/

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter how many numbers would you like to compare: ");
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        Console.WriteLine("First array");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter value for index {0}: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second array");
        for (int j = 0; j < n; j++)
        {
            Console.Write("Enter value for index {0}: ", j);
            secondArray[j] = int.Parse(Console.ReadLine());
        }

        for (int k = 0; k <n; k++)
        {
           int bigger=0;
           int smaller=0;
            if (firstArray[k] > secondArray[k])
            {
                bigger = firstArray[k];
                smaller = secondArray[k];
                Console.WriteLine("Index {2}: {0} > {1}", bigger, smaller, k);
            }
            else if (firstArray[k] < secondArray[k])
            {
                bigger = secondArray[k];
                smaller = firstArray[k];
                Console.WriteLine("Index {2}: {0} > {1}", bigger, smaller, k);
            }
            else if(firstArray[k] == secondArray[k])
            {

                Console.WriteLine("Index {2}: {0} = {1}", firstArray[k], secondArray[k], k);
            }
        }
    }
}

