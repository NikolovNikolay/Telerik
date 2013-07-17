/*Write a program to check if in a given 
expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/

using System;

class Brackets
{
    static void Main()
    {
        Console.WriteLine("Enter some expression:");
        //string expression = "))a+b( -c)";
        string expression = Console.ReadLine();

        int leftBracket = 0;
        int rightBracket = 0;

        for (int i = 0; i < expression.Length; i++)
        {
            if (expression[i] == '(')
            {
                leftBracket++;
            }

            else if (expression[i] == ')')
            {
                rightBracket++;
            }
        }

        if (expression.IndexOf('(', 0) > expression.IndexOf(')') || expression.IndexOf('(') == -1 || leftBracket != rightBracket)
        {
            Console.WriteLine("Error in expression!");
        }
        else
        {
            Console.WriteLine("Expression is correct");
        }
        
       
    }
}
