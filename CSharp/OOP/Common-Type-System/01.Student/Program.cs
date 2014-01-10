/* 1.Define a class Student, which contains data about a student – first,
 *   middle and last name, SSN, permanent address, mobile phone e-mail, course,
 *   specialty, university, faculty. Use an enumeration for the specialties,
 *   universities and faculties. Override the standard methods, inherited by 
 *   System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
 * 2.Add implementations of the ICloneable interface. The Clone() method should
 *   deeply copy all object's fields into a new object of type Student.
 * 3.Implement the  IComparable<Student> interface to compare students by names
 *   (as first criteria, in lexicographic order) and by social security number 
 *   (as second criteria, in increasing order).
*/

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
