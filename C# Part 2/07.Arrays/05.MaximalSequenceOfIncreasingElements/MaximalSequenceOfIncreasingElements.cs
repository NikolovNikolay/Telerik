/*Write a program that finds the maximal increasing sequence in an array. Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
*/

using System;

class MaximalSequenceOfIncreasingElements
{
    static void Main()
    {
        Console.Write("Enter how many numbers would you like to compare? ");
        int n = int.Parse(Console.ReadLine());
        int len = 1;
        int greatestIncrease = 0;
        int lastNumber = 0;

        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Enter value for number {0}: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int j = 0; j < array.Length - 1; j++)
        {
            if (array[j] < array[j + 1])
            {
                if (array[j] == (array[j + 1] - 1))
                {
                    len++;
                }
                else
                {
                    if (len > greatestIncrease)
                    {
                        greatestIncrease = len;
                        lastNumber = j;
                    }
                    len = 1;
                }
            }
        }

            if (len > greatestIncrease)
            {
                greatestIncrease = len;
                lastNumber = array.Length - 1;
            }

                Console.Write("The longest sequance of increasing numbers is: ");
                Console.Write("{");
                for (int k = lastNumber - greatestIncrease + 1; k < lastNumber + 1; k++)
                {
                    Console.Write(" {0} ", array[k]);
                }
                Console.Write("}");
            }
        
    }


