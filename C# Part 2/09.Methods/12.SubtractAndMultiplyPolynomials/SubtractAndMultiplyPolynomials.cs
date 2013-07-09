/*Extend the program to support also subtraction and multiplication of polynomials.
*/

using System;

class SubtractAndMultiplyPolynomials
{
    static void Main()
    {
        //e.g. 5 + 0x + 1x^2 = 5 + 1x^2 
        int[] firstPolynomial = { 5, 0, 1 };
        int[] secondPolynomial = { 5, 0, 1 };
        MultiplyPolynomials(firstPolynomial, secondPolynomial);
        SubtractPolynomials(firstPolynomial, secondPolynomial);
    }

    static void MultiplyPolynomials(int[] firstArray, int[] secondArray)
    {
        int length = 0;
        int subLength = 0;
        bool firstBigger = false;
        if (firstArray.Length >= secondArray.Length)
        {
            length = firstArray.Length;
            subLength = secondArray.Length;
            firstBigger = true;
        }
        else
        {
            length = secondArray.Length;
            subLength = firstArray.Length;
        }

        int[] result = new int[length];

        if (firstBigger)
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    result[j] += firstArray[j] * secondArray[k];
                }
            }
        }
        else
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    result[j] += firstArray[k] * secondArray[j];
                }
            }
        }


        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }

    static void SubtractPolynomials(int[] firstArray, int[] secondArray)
    {
        int length = 0;
        int subLength = 0;
        bool firstBigger = false;
        if (firstArray.Length >= secondArray.Length)
        {
            length = firstArray.Length;
            subLength = secondArray.Length;
            firstBigger = true;
        }
        else
        {
            length = secondArray.Length;
            subLength = firstArray.Length;
        }

        int[] result = new int[length];

        if (firstBigger)
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    result[j] += firstArray[j] - secondArray[k];
                }
            }
        }
        else
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    result[j] += firstArray[k] - secondArray[j];
                }
            }
        }


        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
    }
}
