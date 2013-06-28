using System;

class FillAndPrintMatrix
{
    static void Main()
    {
        int n = 4;
        int[,] matrixOne = new int[n,n];
        int count = 1;
        
        while (count <= 16)
        {
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrixOne[row, col] = count;
                    count++;
                }
            } 
        }

        PrintMatrix(matrixOne, n);
       
        //--------------------------------------------------------------

        int[,] matrixTwo = new int[n, n];
        int currentRow = 0; 
        int currentCol = -1;
        count = 1;

        while (count <= 16)
        {
            if (currentRow == 0)
            {
                currentCol++;
                for (int row = 0; row < n; row++)
                {
                    matrixTwo[row, currentCol] = count;
                    count++;
                }

                currentRow = n - 1;
            }

            if (currentRow == n - 1)
            {
                currentCol++;
                for (int row = n - 1; row >= 0; row--)
                {
                    matrixTwo[row, currentCol] = count;
                    count++;
                }
                currentRow = 0;
            }
        }

        PrintMatrix(matrixTwo, n);
      
        //------------------------------------------------------------

        int[,] matrixThree = { { 7, 11, 14,16 }, { 4, 8, 12, 15 },
                             {2,5,9,13}, {1,3,6,10}};

        PrintMatrix(matrixThree, n);
        //------------------------------------------------------------

        int[,] matrixFour = new int[n, n];

        int startCol = 0;
        int startRow = 0;
        count = 1;
        currentCol = 0;
        currentRow = 0;

        while (count <= 16)
        {
            for (int row = 0; row < n; row++)
            {
                matrixFour[currentRow, currentCol] = count;
                count++;
                currentRow++;
            }

            currentRow--;
            currentCol++;

            for (int col = 0; col < n - 1; col++)
            {
                matrixFour[currentRow, currentCol] = count;
                count++;
                currentCol++;
            }

            currentCol--;
            currentRow--;

            for (int row = 0; row < n - 1; row++)
            {
                matrixFour[currentRow, currentCol] = count;
                currentRow--;
                count++;
            }

            currentRow++;
            currentCol--;

            for (int col = 0; col < n - 2; col++)
            {
                matrixFour[currentRow, currentCol] = count;
                currentCol--;
                count++;
            }

            currentRow++;
            currentCol++;

            for (int row = 0; row < n - 2; row++)
            {
                matrixFour[currentRow, currentCol] = count;
                count++;
                currentRow++;
            }

            currentCol++;
            currentRow--;

            for (int col = 0; col < n - 2; col++)
            {
                matrixFour[currentRow, currentCol] = count;
                currentRow--;
                count++;
            }
        }
        PrintMatrix(matrixFour, n);
    }

    static void PrintMatrix(int[,] matrix, int n)
    {
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

