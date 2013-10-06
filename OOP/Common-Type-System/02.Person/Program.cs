using System;
using System.Linq;

namespace _02.Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person man = new Person("Pesho", 21);
            Person manToo = new Person("Gosho");

            Console.WriteLine(man.ToString());
            Console.WriteLine(manToo.ToString());
        }
    }
}
