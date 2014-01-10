/* 5. Using the extension methods OrderBy() and ThenBy() with lambda 
 *    expressions sort the students by first name and last name in
 *    descending order. Rewrite the same with LINQ.
*/

using System;
using System.Collections;
using System.Linq;

namespace OrderDescendingNames
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
            // using lambda expressions
            var orderedByExtension = students.OrderByDescending(first => first.FirstName).ThenByDescending(last => last.LastName);

            // using LINQ
            var orderByLinq =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            PrintNames(orderedByExtension);
            Console.WriteLine();
            PrintNames(orderByLinq);
            
                        
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
