/*Sort 3 real values in descending order
 * using nested if statements*/

using System;

class SortDescending
{
    static void Main()
    {
        // Nested If solution
        Console.WriteLine("Enter three numbers ");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("The numbers are equal");
        }
        else if (firstNumber != secondNumber && firstNumber != thirdNumber && secondNumber != thirdNumber && secondNumber != firstNumber
            && thirdNumber != secondNumber && thirdNumber != firstNumber)
        {
            if (firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber < secondNumber && secondNumber > thirdNumber && thirdNumber < firstNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", secondNumber, firstNumber, thirdNumber);
            }
            else if (firstNumber < secondNumber && secondNumber > thirdNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", secondNumber, thirdNumber, firstNumber);
            }
            else if (firstNumber > secondNumber && secondNumber < thirdNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", thirdNumber, firstNumber, secondNumber);
            }
            else if (firstNumber > secondNumber && secondNumber < thirdNumber && thirdNumber < firstNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if (thirdNumber > secondNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
            else if (firstNumber == secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", firstNumber, secondNumber, thirdNumber);
            }
            else if (firstNumber == thirdNumber && firstNumber > secondNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", firstNumber, thirdNumber, secondNumber);
            }
            else if (thirdNumber == secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine("Sorted: {0} {1} {2}", thirdNumber, secondNumber, firstNumber);
            }
        }
        else
        {
            Console.WriteLine("Please input different numbers!");
        }
    }
}

