using System;
using System.Linq;

namespace _01.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student("vfdv", "vfvfv", "vfv", "34ff43r4v0");
            Student two = new Student("fdvfdv", "vfdvdfv", "vfvfdvfdvdf", "34324ffdv3", "tam nqkude testvam, malko az", "90839489", "vfdvfd@vfvf.com",
                Course.Fourth, Faculty.Economics, Specialty.Audit, University.UNSS);

            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            Console.WriteLine(one.SSN == two.SSN);

            var clonedOne = two.Clone() as Student;
            Console.WriteLine(clonedOne.ToString());
            Console.WriteLine(one.GetHashCode());
            Console.WriteLine(two.GetHashCode());
            clonedOne.FirstName = "fdvfv";
            Console.WriteLine(clonedOne.GetHashCode());
        }
    }
}
