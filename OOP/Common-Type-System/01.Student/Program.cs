using System;
using System.Linq;

namespace _01.Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Student one = new Student("vfdv", "vfvfv", "vfv", "34ff43r4");
            Student two = new Student("fdvfdv", "vfdvdfv", "vfvfdvfdvdf", "34324ffdv", "tam nqkude testvam, malko az", "90839489", "vfdvfd@vfvf.com",
                "First", Faculty.Economics, Specialty.Audit, University.UNSS);
            Console.WriteLine(one.ToString());
            Console.WriteLine(two.ToString());
            Console.WriteLine(one.SSN == two.SSN);

            var clonedOne = two.Clone();
            Console.WriteLine(clonedOne.ToString());
        }
    }
}
