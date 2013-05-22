/*Write a program that finds the biggest of
 * three integers using nested if statements.*/

using System;

class BiggestOfThree
{
    static void Main()
    {
        // Nested If solution
        Console.WriteLine("Input three numbers");
        int firstNumber = Int32.Parse(Console.ReadLine());
        int secondNumber = Int32.Parse(Console.ReadLine());
        int thirdNumber = Int32.Parse(Console.ReadLine());

        if (firstNumber == secondNumber && secondNumber == thirdNumber )
        {
            Console.WriteLine("The numbers are equal");
        }
        else 
        {
            if (firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The greatest number is {0}", firstNumber);
            }
            else if (firstNumber < secondNumber && secondNumber > thirdNumber)
            {
                Console.WriteLine("The greatest number is {0}", secondNumber);
            }
            else if (firstNumber > secondNumber && secondNumber < thirdNumber && thirdNumber > firstNumber)
            {
                Console.WriteLine("The greatest number is {0}", thirdNumber);
            }
            else if (firstNumber > secondNumber && secondNumber < thirdNumber && thirdNumber < firstNumber)
            {
                Console.WriteLine("The greatest number is {0}", firstNumber);
            }
            else if (thirdNumber > secondNumber && secondNumber > firstNumber)
            {
                Console.WriteLine("The greatest number is {0}", thirdNumber);
            }
            else if (firstNumber == secondNumber && firstNumber > thirdNumber)
            {
                Console.WriteLine("The greatest number is {0}", firstNumber);
            }
            else if (firstNumber == thirdNumber && firstNumber > secondNumber)
            {
                Console.WriteLine("The greatest number is {0}", firstNumber);
            }
            else if (thirdNumber == secondNumber && firstNumber < thirdNumber)
            {
                Console.WriteLine("The greatest number is {0}", thirdNumber);
            }
        }
        
    }
}

