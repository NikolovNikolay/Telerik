using System;

class Polynomials
{
    static void Main()
    {
        //e.g. 1 + 2x + 3x^2 = 3 + 2x + 1x^2 
        int[] firstPolynomial = { 5, 0, 1 };
        int[] secondPolynomial = { 5, 0, 1 };
        SumPolynomials(firstPolynomial, secondPolynomial);
    }

    static void SumPolynomials(int[] firstArray, int[] secondArray)
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
                    result[j] += firstArray[j] + secondArray[k];
                }
            }
        }
        else
        {
            for (int j = 0; j < length; j++)
            {
                for (int k = 0; k < subLength; k++)
                {
                    result[j] += firstArray[k] + secondArray[j];
                }
            }
        }


        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
    }
}
