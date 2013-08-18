/*Write a method ReadNumber(int start, int end)
 * that enters an integer number in given range
 * [start…end]. If an invalid number or non-numbe
 * r text is entered, the method should throw an 
 * exception. Using this method write a program 
 * that enters 10 numbers:
			a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/

using System;

class TenNumbers
{
    static void Main()
    {
        int start = 1;
        int end = 100;

        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number bigger than {0} to {1}", start, end);
                start = ReadNumber(start, end);
            }
        }
        catch (ArgumentOutOfRangeException aoe)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (FormatException fe)
        {
            Console.WriteLine("You must enter a number or digit in the interval given!");
        }
    }

    static int ReadNumber(int start, int end)
    {
        if (start > end)
        {
            throw new ArgumentException("First digit is bigger than the proximate");
        }

        int number = int.Parse(Console.ReadLine());

        if (start < number && number < end)
        {
            return number;
        }
        else
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}