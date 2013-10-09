using System;
using System.Linq;

namespace _04.BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            for (int i = 1; i <= 50; i++)
            {
                tree.Insert(i);
            }

            Console.WriteLine(tree.ToString());
        }
    }
}
