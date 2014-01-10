/** We are given a labyrinth of size N x N. Some of its cells 
 * are empty (0) and some are full (x). We can move from an empty
 * cell to another empty cell if they share common wall. Given a
 * starting position (*) calculate and fill in the array the minimal
 * distance from this position to any other cell in the array. 
 * Use "u" for all unreachable cells.
 */

namespace Labyrinth
{
    using System;
    using System.Collections.Generic;

    class Labyrinth
    {
        private static string[,] matrix = new string[,] {
                    {"0", "0","0","x","0","x"},
                    {"0", "x","0","x","0","x"},
                    {"0", "*","x","0","x","0"},
                    {"0", "x","0","0","0","0"},
                    {"0", "0","0","x","x","0"},
                    {"0", "0","0","x","0","x"}
            };

        private static int initialCounter = 0;
        private static int startRow = 2;
        private static int startCol = 1;
        private static Location startLocation = new Location(startRow, startCol, initialCounter);

        static void Main()
        {
            SolveMatrix(matrix);
        }

        public static void SolveMatrix(string[,] matrix)
        {
            VisitAllCells(matrix);
            MarkUnreachable();
            PrintMatrix();
        }

        private static void MarkUnreachable()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == "0")
                    {
                        matrix[row, col] = "u";
                    }
                }
            }
        }

        private static void PrintMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void VisitAllCells(string[,] matrix)
        {            
            Stack<Location> positions = new Stack<Location>();

            positions.Push(startLocation);

            while (positions.Count != 0)
            {
                Location currentLocation = positions.Pop();
                int currentRow = currentLocation.Row;
                int currentCol = currentLocation.Col;
                int count = currentLocation.Value;

                if(currentLocation.Row == startLocation.Row && startLocation.Col == currentLocation.Col)
                {
                    matrix[currentRow, currentCol] = "*";
                }
                else
                {
                    matrix[currentRow, currentCol] = count.ToString();
                }

                if(currentCol > 0 && matrix[currentRow,currentCol - 1] == "0")
                {
                    positions.Push(new Location(currentRow, currentCol-1, count+1));
                }
                if(currentCol < (matrix.GetLength(1) - 1) && matrix[currentRow, currentCol +1] == "0")
                {
                    positions.Push(new Location(currentRow, currentCol + 1, count+1));
                }
                if(currentRow > 0 && matrix[currentRow - 1, currentCol] == "0")
                {
                    positions.Push(new Location(currentRow-1, currentCol, count+1));
                }
                if(currentRow < matrix.GetLength(0) - 1 && matrix[currentRow+1, currentCol] == "0")
                {
                    positions.Push(new Location(currentRow+1, currentCol, count + 1));
                }
            }
        }
    }
}
