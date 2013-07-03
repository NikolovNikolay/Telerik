/** Write a program that finds the largest
 * area of equal neighbor elements in a
 * rectangular matrix and prints its size.*/

using System;

class LargestArrea
{
    static int number;
    static int bestNumber;
    static int count = 0;
    static int maxCount = 0;

    static void Main()
    {

        int[,] matrix = {
                        {1,3,2,2,2,4},
                        {3,3,3,2,4,4},
                        {4,3,1,2,3,3},
                        {4,3,1,3,3,1},
                        {4,3,3,3,1,1}
                        };

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                number = matrix[row, col];
                count = 0;
                DepthFirstSearch(matrix, row, col);
            }
        }
        Console.WriteLine("Best element: {0}, with length {1}",bestNumber,maxCount );
    }

    static void DepthFirstSearch(int[,] multidimensionalArray, int a, int b)
    {
        if (a < 0 || a >= multidimensionalArray.GetLength(0) || b < 0 || b >= multidimensionalArray.GetLength(1))
        {
            return;
        }

        if (multidimensionalArray[a, b] != number)
        {
            return;
        }

        count++;
        if (count > maxCount)
        {
            maxCount = count;
            bestNumber = number;
        }

        multidimensionalArray[a, b] = 0;
        DepthFirstSearch(multidimensionalArray, a, b + 1);
        DepthFirstSearch(multidimensionalArray, a + 1, b);
        DepthFirstSearch(multidimensionalArray, a, b - 1);
        DepthFirstSearch(multidimensionalArray, a - 1, b);
        multidimensionalArray[a, b] = number;
    }
}


