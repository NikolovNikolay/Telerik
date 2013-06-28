using System;

class RectangularMatrix3x3
{
    static void Main()
    {
        Console.Write(@"Enter ""N >= 3"": ");
        int N = int.Parse(Console.ReadLine());
        Console.Write(@"Enter ""M >= 3"": ");
        int M = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, M];
        Random randomGenerator = new Random();

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                matrix[row, col] = randomGenerator.Next(1, 10);
            }
        }

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                Console.Write("{0,3}",matrix[row, col]);
            }
            Console.WriteLine();
        }

        int sum = 0;
        int maximalSum = 0;
        string sequence = "";
        string bestSequence = "";

        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < M; col++)
            {
                sum = 0;
                sequence = "";
                if (row + 2 < N && col + 2 < M)
                {
                    for (int i = row; i < row + 3; i++)
                    {
                        for (int j = col; j < col + 3; j++)
                        {
                            sum = sum + matrix[i, j];
                            sequence = sequence +matrix[i, j];
                        }
                    }

                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                        bestSequence = sequence;
                    }
                }
            }
        }
        int[,] bestSequenceMatrix = new int[3, 3];
        int[] digitsArray = new int[bestSequence.Length];

        for (int i = 0; i < bestSequence.Length; i++)
        {
            digitsArray[i] = Convert.ToInt32(new string(bestSequence[i], 1));
        }
        int element = 0;

        Console.WriteLine("The maximal sum is: {0}",maximalSum);
        Console.WriteLine("With elements: ");
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                
                bestSequenceMatrix[i, j] = digitsArray[element];
                element++;
                Console.Write("{0,3}",bestSequenceMatrix[i,j]);
            }
            Console.WriteLine();
        }
        
        //Console.WriteLine(bestSequence);
    }
}