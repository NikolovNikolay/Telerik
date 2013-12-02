/*Implement the data structure linked list. Define a class ListItem<T>
 * that has two fields: value (of type T) and NextItem (of type ListItem<T>).
 * Define additionally a class LinkedList<T> with a single 
 * field FirstElement (of type ListItem<T>).
*/

namespace LinkedListImplementation
{
    using System;
    using System.Collections.Generic;

    class LinkedListImplementation
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();

            list.AddFirst(1);
            list.AddFirst(2);
            list.AddFirst(3);
            list.AddLast(4);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
