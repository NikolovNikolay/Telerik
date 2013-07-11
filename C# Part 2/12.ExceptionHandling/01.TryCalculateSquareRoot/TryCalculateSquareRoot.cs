/*Write a program that reads an integer 
 * number and calculates and prints its
 * square root. If the number is invalid 
 * or negative, print "Invalid number". 
 * In all cases finally print "Good bye".
 * Use try-catch-finally.
*/

using System;

class TryCalculateSquareRoot
{
    static void Main()
    {
        string number = Console.ReadLine();

        try
        {
            double stringToNumber = double.Parse(number);
            if (stringToNumber < 0 || stringToNumber == 0)
            {
                throw new ArgumentException();
            }
            Console.WriteLine(Math.Sqrt(stringToNumber));
        }
        catch (FormatException an)
        {
            Console.WriteLine("Invalid number!");
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine("Invalid number!");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
