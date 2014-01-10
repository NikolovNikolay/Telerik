/* 3. Write a method that from a given array of students finds all students 
 *    whose first name is before its last name alphabetically. Use LINQ query operators.
*/

using System;
using System.Collections;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[] {
            new { FirstName = "Petyr", LastName = "Borisov"},
            new { FirstName = "Boris", LastName = "Petrov"},
            new { FirstName = "Alek",  LastName = "Dimitrov"},
            new { FirstName = "Evlogi", LastName = "Atanasov"}
        };

        var sortedNames = from student in students
                          where student.FirstName.CompareTo(student.LastName) < 0
                          select student;

        PrintSortedNames(sortedNames);
    }

    private static void PrintSortedNames(IEnumerable array)
    {
        foreach (var names in array)
        {
            Console.WriteLine(names);
        }
    }
}
