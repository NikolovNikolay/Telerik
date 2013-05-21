/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
 * The program must show the value of that variable as a console output. Use switch statement.*/

using System;

class UserChoice
{
    static void Main()
    {
        Console.WriteLine(@"Input ""1"" for int, ""2"" for double or ""3"" for string");
        byte userChoice = byte.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 1:
                int inputInt = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", (inputInt+1));
                break;
            case 2:
                double inputDouble = Double.Parse(Console.ReadLine());
                Console.WriteLine("Result: {0}", (inputDouble+1));
                break;
            case 3:
                string inputString = Console.ReadLine();
                Console.WriteLine("Result: {0}*", inputString);
                break;
            default:
                Console.WriteLine("Please choose a valid number!");
                break;
        }
    }
}

