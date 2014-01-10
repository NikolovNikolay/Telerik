/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
*/

using System;

class SolvingMultipleTasks
{
    static void Main()
    {
        while (true)
        {
            byte selection = InputMenu();
            bool exit = false;
            switch (selection)
            {
                case 1: Console.Clear(); ReverseDigits(); break;
                case 2: Console.Clear(); CalculateAverage(); break;
                case 3: Console.Clear(); SolveEquation(); break;
                case 0: exit = true; break;
                default: Console.Clear(); InputMenu(); break;
            }
            if (exit) break;
        }
    }

    private static byte InputMenu()
    {
        Console.WriteLine("Please choose from the following options:");
        Console.WriteLine(@"1.Input ""1"" to reverse the digits of a number.");
        Console.WriteLine(@"2.Input ""2"" to calculate the average of a sequence of integers.");
        Console.WriteLine(@"3.Input ""3"" to solve the linear euastion a*x + b = 0");
        Console.WriteLine(@"4.Input ""0"" to exit.");

        Console.Write("Your choice: ");
        byte selection = byte.Parse(Console.ReadLine());
        return selection;
    }

    static void ReverseDigits()
    {
        Console.Write("Input positive number: ");
        decimal number = decimal.Parse(Console.ReadLine());

        if (number < 0)
        {
            ReverseDigits();
        }
        else
        {
            string numberToString = number.ToString();
            string result = "";

            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                result = result + numberToString[i];
            }

            if (result != "0")
            {
                result = result.TrimStart('0');
                result = result.TrimStart('.'); 
            }
            Console.WriteLine(result);
        }
        Console.WriteLine("Press button to continue ...");
        Console.ReadKey();
        Console.Clear();
    }

    static void CalculateAverage()
    {
        Console.Write("How many integers would you like to input? ");
        int quantity = int.Parse(Console.ReadLine());
        int sum = 0;
        decimal average = 0;
        int[] array = new int[quantity];
        if (quantity > 0)
        {
            Console.WriteLine("Input numbers: ");
            for (int i = 0; i < quantity; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            average = (decimal)sum / quantity;
            Console.WriteLine("{0:F5}", average);
        }
        else
        {
            CalculateAverage();
        }

        Console.WriteLine("Press button to continue ...");
        Console.ReadKey();
        Console.Clear();
        
    }

    static void SolveEquation()
    {
        Console.Write("Input a = ");
        int a = int.Parse(Console.ReadLine());
        if (a > 0 || a < 0)
        {
            Console.Write("Input b = ");
            int b = int.Parse(Console.ReadLine());

            decimal x = (decimal)(-b / a);

            Console.WriteLine("{0:F5}", x);
        }
        else
        {
            SolveEquation();
        }

        Console.WriteLine("Press button to continue ...");
        Console.ReadKey();
        Console.Clear();
    }
}
