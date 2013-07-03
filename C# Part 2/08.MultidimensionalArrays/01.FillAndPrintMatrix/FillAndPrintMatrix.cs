/*Write a program that fills and prints a matrix of size (n, n) as shown*/

using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        Console.Write("Input n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrixOne = new int[n, n];
        int counter = 1;
        int row = 0;
        int col = 0;

        for (int mCol = col; mCol < n; mCol++)
        {
            for (int mRow = row; mRow < n; mRow++)
            {
                matrixOne[mRow, mCol] = counter;
                counter++;
            }
        }
        PrintMatrix(matrixOne);
        //------------------------------------------------------------
        
        row = 0;
        col = 0;

        int[,] matrixTwo = new int[n, n];

        string direction = "down";

        counter = 1;
        for (int mCol = 0; mCol < n; mCol++)
        {
            if (direction == "down" && mCol % 2 == 0)
            {
                for (int mRow = 0; mRow < n; mRow++)
                {
                    matrixTwo[mRow, mCol] = counter;
                    counter++;
                }
                direction = "up";
                
            }

            if (direction == "up" && mCol % 2 != 0)
            {
                for (int mRow = n - 1; mRow >= 0; mRow--)
                {
                    matrixTwo[mRow, mCol] = counter;
                    counter++;
                }
                direction = "down";
                
            }
        }
        PrintMatrix(matrixTwo);
        //----------------------------------------------------------------

        int[,] matrixThree = new int[n, n];

        int initialRow = n - 1;
        int initialCol = 0;
        counter = 1;
        direction = "up";
        col = 0;

        for ( int i = n; i >= 0 ; i--)
        {
            int mRow = i;
            mRow--;
            if (mRow >= 0)
            {
                while (mRow <= n - 1)
                {

                    matrixThree[mRow, col] = counter;
                    mRow++;
                    col++;
                    counter++;
                }
                col = 0;
            }
        }

        row = 0;
        for (int i = 1; i < n; i++)
        {
            int mCol = i;
            while (mCol < n)
            {
                matrixThree[row, mCol] = counter;
                row++;
                mCol++;
                counter++;
                

            }
            row = 0;
        }
        PrintMatrix(matrixThree);
        // ---------------------------------------------------------
        int[,] matrixFour = new int[n,n];
        int activeRow = 0;
        int activeCol = 0;
        counter = 1;
        int maxRow = n - 1;
        int maxCol = n - 1;

        while (counter <= n * n)
        {
            for (int i = activeRow; i <= maxRow; i++)
            {
                matrixFour[i, activeCol] = counter;
                counter++;
            }
            activeCol++;

            for (int i = activeCol; i <= maxCol; i++)
            {
                matrixFour[maxRow, i] = counter;
                counter++;
            }
            maxRow--;

            for (int i = maxRow; i >= activeRow; i--)
            {
                matrixFour[i, maxCol] = counter;
                counter++;
            }
            maxCol--;

            for (int i = maxCol; i >= activeCol; i--)
            {
                matrixFour[activeRow, i] = counter;
                counter++;
            }
            activeRow++;
        }

        PrintMatrix(matrixFour);
    }


    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row,col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

