﻿/*We are given a matrix of strings of size N x M.
 * Sequences in the matrix we define as sets of 
 * several neighbor elements located on the same 
 * line, column or diagonal. Write a program that
 * finds the longest sequence of equal strings 
 * in the matrix. */

using System;

class LongestSequenceOfEqualStrings
{
    static void Main()
    {
        //Console.Write("N = ");
        //int N = int.Parse(Console.ReadLine());
        //Console.Write("M = ");
        //int M = int.Parse(Console.ReadLine());

        string[,] matrix = { {"ha", "fifi", "ho", "hi"},
                             {"fo", "ha", "hi", "xx"},
                             {"xxx", "ho", "ha", "xx"}
                           };

        //string[,] matrix = { { "s", "qq", "s"},
        //                     { "pp", "pp", "s" },
        //                     { "pp", "qq", "s"} 
        //                   };

        PrintMatrix(matrix);

        string sequence = "";
        string longestSequence = "";
        int length = 1;
        int biggestLength = 1;

        // horizontal check
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            length = 1;
            sequence = "";
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    sequence = matrix[row, col];
                    length++;
                }
            }

            if (biggestLength < length)
            {
                biggestLength = length;
                longestSequence = sequence;
            }
        }

        // vertical check
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            length = 1;
            for (int row = 0; row < matrix.GetLength(0) -1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    sequence = matrix[row, col];
                    length++;
                }
            }
            
            if (biggestLength < length)
            {
                biggestLength = length;
                longestSequence = sequence;
            }
        }

        length = 1;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            //length = 1;
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (row == col)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        sequence = matrix[row, col];
                        length++;
                    }
                }
            }
            if (biggestLength < length)
            {
                biggestLength = length;
                longestSequence = sequence;
            }
        }
        PrintLongestSequence(biggestLength, longestSequence);
     }

    static void PrintMatrix(string[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,6}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void PrintLongestSequence(int biggestLength, string longestSequence)
    {
        Console.WriteLine();
        for (int i = 0; i < biggestLength; i++)
        {
            Console.Write("{0} ", longestSequence);
        }
        Console.WriteLine();
    }
}
