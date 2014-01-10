/*Implement the ADT stack as auto-resizable array. 
 * Resize the capacity on demand 
 * (when no space is available to add / insert a new element).
*/

namespace ADTStack
{
    using System;
    using System.Collections.Generic;

    class ADTStack
    {
        static void Main()
        {
            GenericStack<int> stakche = new GenericStack<int>();

            for (int i = 1; i <= 5; i++)
            {
                stakche.Push(i);
            }

            for (int i = 0; i < stakche.AllElements; i++)
            {
                Console.WriteLine(stakche[i]);
            }
            Console.WriteLine();

            var popped = stakche.Pop();
            Console.WriteLine(popped);
            Console.WriteLine();

            for (int i = 0; i < stakche.AllElements; i++)
            {
                Console.WriteLine(stakche[i]);
            }
        }
    }
}
