/*Write a program that reads N integers from the console and reverses them using a stack. Use the Stack<int> class.
*/

namespace ReverseOrderWithStack
{
    using System;
    using System.Collections.Generic;

    class ReverseOrderWithStack
    {
        static void Main()
        {
            var stack = new Stack<int>();

            Console.WriteLine("Input integers and press enter. Empty line breaks input.");
            FillStack(stack);
            Console.WriteLine("Reversed:");
            ReverseStack(stack);
            
        }

        private static void FillStack(Stack<int> stack)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if(string.IsNullOrEmpty(input))
                {
                    return;
                }
                else
                {
                    stack.Push(int.Parse(input));
                }
            }
        }

        private static void ReverseStack(Stack<int> stack)
        {
            while (stack.Count > 0)
            {
               // int element = stack.Pop();
                Console.Write("{0} ", stack.Pop());
            }
            Console.WriteLine();
        }

    }
}
