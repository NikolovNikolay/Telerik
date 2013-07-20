/*Write a program that fills and prints a matrix of size (n, n) as shown*/

using System;

class FillAndPrintMatrix
{
    static int n;

    private static void InitializeArgumentsAndContainingLogic(int n)
    {
        int[,] matrixOne;
        int row;
        int col;
        int counter;
        ImplementLogicForMatrixOne(n, out matrixOne, out row, out col, out counter);
        PrintMatrix(matrixOne);
                      
        int[,] matrixTwo;
        string direction;
        ImplementLogicForMatrixTwo(n, ref row, ref col, ref counter, out matrixTwo, out direction);
        PrintMatrix(matrixTwo);

        int[,] matrixThree = ImplementLogicForMatrixThree(n, ref counter, ref direction, ref col, ref row);
        PrintMatrix(matrixThree);

        int[,] matrixFour = ImplementLogicForMatrixFour(n, ref counter);

        PrintMatrix(matrixFour);
    }
  
    private static int[,] ImplementLogicForMatrixFour(int n, ref int counter)
    {
        int[,] matrixFour = new int[n, n];
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
        return matrixFour;
    }
  
    private static int[,] ImplementLogicForMatrixThree(int n, ref int counter, ref string direction, ref int col, ref int row)
    {
        
        int[,] matrixThree = new int[n, n];

        int initialRow = n - 1;
        int initialCol = 0;
        counter = 1;
        direction = "up";
        col = 0;

        for (int i = n; i >= 0; i--)
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
        return matrixThree;
    }
  
    private static void ImplementLogicForMatrixTwo(int n, ref int row, ref int col, ref int counter, out int[,] matrixTwo, out string direction)
    {
        
        row = 0;
        col = 0;

        matrixTwo = new int[n, n];

        direction = "down";

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
    }
  
    private static void ImplementLogicForMatrixOne(int n, out int[,] matrixOne, out int row, out int col, out int counter)
    {
        matrixOne = new int[n, n];
        counter = 1;
        row = 0;
        col = 0;

        for (int mCol = col; mCol < n; mCol++)
        {
            for (int mRow = row; mRow < n; mRow++)
            {
                matrixOne[mRow, mCol] = counter;
                counter++;
            }
        }
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

    static void Main()
    {
        while (true)
        {
            try
            {
                Console.Write("Input \"n\" for matrix's dimensions = ");
                string input = Console.ReadLine();
                bool par = Int32.TryParse(input, out n);

                if (!par || n == 0)
                    throw new ArgumentException();
                else
                {
                    InitializeArgumentsAndContainingLogic(n);
                    Console.ReadKey();
                    break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter some valid int!");
            }
        }
    }
}

