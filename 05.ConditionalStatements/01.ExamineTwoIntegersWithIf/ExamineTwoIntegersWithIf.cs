/*Write an if statement that examines two integer variables and exchanges their values if the 
first one is greater than the second one.*/

using System;

class ExamineTwoIntegersWithIf
{
static void Main()
{
    Console.WriteLine("Enter two numbers: ");
    int firstNumber = Int32.Parse(Console.ReadLine());
    int secondNumber = Int32.Parse(Console.ReadLine());

    if (firstNumber == secondNumber)
    {
        Console.WriteLine("The numbers are equal");
    }
    else if (secondNumber > firstNumber)
    {
        int temp = 0;
        temp = firstNumber;
        firstNumber = secondNumber;
        secondNumber = temp;
        Console.WriteLine("Second number is bigger than the first, so we swap them: \nFirst number is: {0} \nSecond number is: {1}", firstNumber, secondNumber);
    }
    else if (secondNumber < firstNumber)
    {
        Console.WriteLine("First number: {0} \nSecond number: {1}",firstNumber, secondNumber);
    }
}
}

