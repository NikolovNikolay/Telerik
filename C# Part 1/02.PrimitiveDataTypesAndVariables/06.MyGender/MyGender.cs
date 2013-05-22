/*Declare a boolean variable called 
 * isFemale and assign an appropriate 
 * value corresponding to your gender.
*/

using System;

class MyGender
{
    static void Main()
    {
        bool isFemale = false;
        Console.Write("What is your gender (m/f)? ");
        char gender = char.Parse(Console.ReadLine());
        if (gender != 'm' && gender != 'f')
        {
            Console.WriteLine("Enter \"m\" for Male or \"f\" for Female");
            Environment.Exit(0);
        }
        if (gender == 'f')
        {
            isFemale = true;
        }
        else
        {
            isFemale = false;
        }
        Console.WriteLine(isFemale ? "You are female" : "You are male");
    }
}
