/* 4.Create a class Person with two fields – name and age. Age can be left
 *   unspecified (may contain null value. Override ToString() to display the
 *   information of a person and if age is not specified – to say so. Write a
 *   program to test this functionality.
*/

using System;
using System.Linq;

namespace _02.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person("Pesho", 56);
            Person manToo = new Person("Gosho");

            Console.WriteLine(man.ToString());
            Console.WriteLine(manToo.ToString());
        }
    }
}
