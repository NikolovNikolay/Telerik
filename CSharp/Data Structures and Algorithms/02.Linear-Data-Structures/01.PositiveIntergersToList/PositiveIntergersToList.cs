/*Write a program that reads from the console a sequence of positive integer numbers.
 * The sequence ends when empty line is entered. Calculate and print the sum and average 
 * of the elements of the sequence. Keep the sequence in List<int>.
*/

namespace PositiveIntergersToList
{
    using System;
    using System.Collections.Generic;

    class PositiveIntergersToList
    {
        static void Main()
        {
            List<int> listOfIntergers = new List<int>();

            Console.WriteLine("Input your integers:");
            try
            {
                FillListWithIntegers(listOfIntergers);
                Console.WriteLine("The sum of the integers is: {0}", CalculateSumOfIntegers(listOfIntergers));
                Console.WriteLine("The average of th integers is: {0}",
                    CalculateAverageOfIntegers(CalculateSumOfIntegers(listOfIntergers), listOfIntergers.Count));
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine(ioe.Message);
            }

        }

        private static void FillListWithIntegers(List<int> list)
        {
            while (true)
            {
                try
                {
                    string currentStringInteger = Console.ReadLine();
                    if (string.IsNullOrEmpty(currentStringInteger))
                    {
                        return;
                    }
                    else if (int.Parse(currentStringInteger) < 0)
                    {
                        throw new ArgumentException("Integer should be a positive number! Try again.");
                    }
                    else
                    {
                        list.Add(int.Parse(currentStringInteger));
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        private static int CalculateSumOfIntegers(List<int> list)
        {
            if (list.Count == 0)
            {
                throw new InvalidOperationException("The list is empty!");
            }

            int sum = 0;
            foreach (var integer in list)
            {
                sum += integer;
            }

            return sum;
        }

        private static double CalculateAverageOfIntegers(int sum, int count)
        {
            double average = 0;
            average = (double)sum / count;

            return average;
        }
    }
}
