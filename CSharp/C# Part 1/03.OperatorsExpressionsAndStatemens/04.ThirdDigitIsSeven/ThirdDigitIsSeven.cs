/*Write an expression that checks for given
 * integer if its third digit (right-to-left)
 * is 7. E. g. 1732  true.
*/

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Write("Input number: ");
        int number = int.Parse(Console.ReadLine());

        bool thirdDigitIsSeven = false;
        int division = ((number / 100) % 10);

        if (division == 7)
        {
            thirdDigitIsSeven = true;
        }
        else
        {
            thirdDigitIsSeven = false;
        }
        Console.Write("The third digit is seven (back to front): ");
        Console.Write(thirdDigitIsSeven ? thirdDigitIsSeven : thirdDigitIsSeven);
        Console.WriteLine();
    }
}

