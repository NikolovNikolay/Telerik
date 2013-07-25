/*Write a program that reads a text file
 * containing a square matrix of numbers
 * and finds in the matrix an area of size
 * 2 x 2 with a maximal sum of its elements.
 * The first line in the input file contains
 * the size of matrix N. Each of the next N 
 * lines contain N numbers separated by space.
 * The output should be a single number in a
 * separate text file.*/

using System;
using System.Linq;
using System.IO;

class MaximalSumInMatrix
{
    static void Main()
    {
        SaveBiggestSumInOutputFile(CheckForHighestSum(ReadMatrix()));
    }

    static int[,] ReadMatrix()
    {
        using (StreamReader reader = new StreamReader(@"../../matrix.txt"))
        {
            int matrixDimention = int.Parse(reader.ReadLine());
            int[,] matrix = new int[matrixDimention, matrixDimention];

            for (int i = 0; i < matrixDimention; i++)
            {
                string content = reader.ReadLine();
                string[] digits = content.Split(' ');

                for (int j = 0; j < matrixDimention; j++)
                {
                    matrix[i, j] = int.Parse(digits[j]);
                }
            }
            return matrix;
        }
    }

    static int CheckForHighestSum(int[,] matrix)
    {
        int biggestSum = int.MinValue;
 
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currenSum = 0;
                currenSum = matrix[row, col] + matrix[row + 1, col] +
                    matrix[row + 1, col + 1] + matrix[row, col + 1];

                if (currenSum > biggestSum)
                    biggestSum = currenSum;
            }
        }
        return biggestSum;
    }

    static void SaveBiggestSumInOutputFile(int sum)
    {
        using (StreamWriter writer = new StreamWriter(@"../../result.txt"))
        {
            writer.Write(sum);
        }

        Console.WriteLine("Result file generated!");
    }

}
