using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Input N: ");
        int N = int.Parse(Console.ReadLine());

        Console.Write("Input K: ");
        int K = int.Parse(Console.ReadLine());

        int[] arrayOfIntegers = new int[N];
        Random randomGenerator = new Random();

        for (int i = 0; i < N; i++)
        {
            arrayOfIntegers[i] = randomGenerator.Next(1, 101);
        }

        Array.Sort(arrayOfIntegers);

        for (int i = 0; i < N; i++)
        {
            Console.Write("{0} ",arrayOfIntegers[i]);
        }
        Console.WriteLine();

        int myIndex = Array.BinarySearch(arrayOfIntegers, K);
        if (myIndex < 0)
        {
            if (~myIndex > 0)
            {
                Console.WriteLine("The object to search for ({0}) is not found. The previous smaller object is ({1}) at index {2}.",
                        K, arrayOfIntegers[(~myIndex) - 1], (~myIndex) - 1);
            }
            else
            {
                Console.WriteLine("There is no value, smaller than ({0})", K,
                        K, arrayOfIntegers[0], 0);
            }
        }
        else
            Console.WriteLine( "The object to search for ({0}) is at index {1}.", K, myIndex );
        

    }
}

