/*
 * Write a program that finds the index of given element 
 * in a sorted array of integers by using the binary search
 * algorithm (find it in Wikipedia).
 * */


using System;

class IndexOfGivenElement
{
    static void Main()
    {
        int[] array = { 9, 5, 4, 3, 2, 9, 11, 45, 78, 15, 1 };
        int key = 11;

        //sorting the array
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] > array[j])
                {
                    int temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;
                }
            }
        }
        Console.WriteLine(BinarySearch(array, key));
    }

    public static int BinarySearch(int[] A, int key)
    {
        int imax = A.Length - 1;
        int imin = 0;

        while (imax >= imin)
        {
            int imid = (imin + imax) / 2;

            if (A[imid] < key)
            {
                imin = imid + 1;
            }
            else if (A[imid] > key)
            {
                imax = imid - 1;
            }
            else
            {
                return imid;
            }
        }
        return -1;
    }
}

