/* 4. Write a LINQ query that finds the first name
 *    and last name of all students with age between 18 and 24.
*/

using System;
using System.Collections;
using System.Linq;

namespace NamesIfCorrectAge
{
    class Program
    {
        static void Main()
        {
            var students = new[] {
                                     new { FirstName = "Alek", LastName = "Petrov", Age = 19},
                                     new { FirstName = "Boris", LastName = "Todorov", Age = 23},
                                     new { FirstName = "Petyr", LastName = "Stoichev", Age = 17},
                                     new { FirstName = "Stoicho", LastName = "Aleksandrov", Age = 25}
                                 };

            var gotNames = from student in students
                           where student.Age > 18 && student.Age < 25
                           select new { student.FirstName, student.LastName };

            PrintNames(gotNames);
        }

        private static void PrintNames(IEnumerable array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
