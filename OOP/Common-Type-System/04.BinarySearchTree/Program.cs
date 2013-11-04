/* 6. * Define the data structure binary search tree with operations
 * for "adding new element", "searching element" and "deleting elements".
 * It is not necessary to keep the tree balanced. Implement the standard 
 * methods from System.Object – ToString(), Equals(…), GetHashCode() and
 * the operators for comparison  == and !=. Add and implement the ICloneable
 * interface for deep copy of the tree. Remark: Use two types – structure
 * BinarySearchTree (for the tree) and class TreeNode (for the tree elements).
 * Implement IEnumerable<T> to traverse the tree.
*/

using System;
using System.Linq;

namespace _04.BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<double> tree = new BinarySearchTree<double>(); // could work with int and other types, which can be compared

            //Random rand = new Random();
            //for (int i = 1; i <= 50; i++)
            //{
            //    tree.Insert(rand.Next(1,101));
            //}

            // every node is being checked, reaching the leafes, so the elements are sorted
            tree.Insert(90.45);
            tree.Insert(0);
            tree.Insert(1);
            tree.Insert(10);
            tree.Insert(45);
            tree.Insert(23);
            tree.Insert(90.44);

            Console.WriteLine(tree.ToString());
        }
    }
}
