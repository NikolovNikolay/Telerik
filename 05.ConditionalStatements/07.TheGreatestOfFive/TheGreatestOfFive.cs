/*Write a program that finds the greatest of given 5 variables.*/

using System;

class TheGreatestOfFive
{
    static void Main()
    {
        Console.WriteLine("Input five numbers:");
        int one = Int32.Parse(Console.ReadLine());
        int two = Int32.Parse(Console.ReadLine());
        int three = Int32.Parse(Console.ReadLine());
        int four = Int32.Parse(Console.ReadLine());
        int five = Int32.Parse(Console.ReadLine());

        //First way
        int big1 = 0;
        int big2 = 0;
        int big3 = 0;
        int big = 0;
        
        if (one == two && two == three && three == four && four == five)
        {
            Console.WriteLine("The numbers are equal!");
        }
        else
        {
            if (one > two)
            {
                big1 = one;
            }
            else
            {
                big1 = two;
            }
            if (three > four)
            {
                big2 = three;
            }
            else
            {
                big2 = four;
            }
            if (big1 > big2)
            {
                big = big1;
            }
            else
            {
                big = big2;
            }
            if (big > five)
            {
                Console.WriteLine("The greatest number, chosen by the first way is {0}", big);
            }
            else if (five > big)
            {
                Console.WriteLine("The greatest number, chosen by the first way is {0}", five);
            }
        }
      
        //Second way  
        int biggest = Math.Max(Math.Max((Math.Max(one, two)), Math.Max(three, four)), five);
        Console.WriteLine("The greatest number, chosen by the second way is {0}",biggest);
    }
}
        

