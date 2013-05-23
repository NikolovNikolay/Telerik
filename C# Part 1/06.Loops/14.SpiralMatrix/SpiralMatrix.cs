/*Write a program that reads a positive
 * integer number N (N < 20) from console
 * and outputs in the console the numbers 1 ... N
 * numbers arranged as a spiral.
                             *  0  1  2  3  4
                                ---------------
                            0  |1  2  3  4  5
                            1  |16 17 18 19 6
                            2  |15 24 25 20 7
                            3  |14 23 22 21 8
                            4  |13 12 11 10 9
*/

using System;

class SpiralMatrix
{
    static void Main()
    {
        Console.Write("Input number for width and height of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int activeRow = 0;
        int activeCol = 0;
        int numeric = 1;
        int maxRow = n-1;
        int maxCol = n-1;

        while (numeric <= n * n)
        {
            for (int i = activeCol; i <= maxCol; i++)
            {
                matrix[activeRow, i] = numeric;
                numeric++;
            }
            activeRow++;

            for (int i = activeRow; i <= maxRow; i++)
            {
                matrix[i, maxCol] = numeric;
                numeric++;
            }
            maxCol--;

            for (int i = maxCol; i >= activeCol; i--)
            {
                matrix[maxRow, i] = numeric;
                numeric++;
            }
            maxRow--;

            for (int i = maxRow; i >= activeRow; i--)
            {
                matrix[i, activeCol] = numeric;
                numeric++;
            }
            activeCol++;
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,3}", matrix[i,j]);
            }
            Console.WriteLine();
        }
    }
}