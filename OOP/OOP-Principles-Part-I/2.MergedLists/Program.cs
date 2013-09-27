/* 2. Define abstract class Human with first name and last name. Define new class Student
 * which is derived from Human and has new field – grade. Define class Worker derived
 * from Human with new property WeekSalary and WorkHoursPerDay and method MoneyPerHour() 
 * that returns money earned by hour by the worker. Define the proper constructors and 
 * properties for this hierarchy. Initialize a list of 10 students and sort them by grade 
 * in ascending order (use LINQ or OrderBy() extension method). Initialize a list of 10 workers 
 * and sort them by money per hour in descending order. Merge the lists and sort them by
 * first name and last name.
*/

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _2.MergedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            List<Student> students = new List<Student>();
            students.Add(new Student("Petyr", "Georgiev", 5.60f));
            students.Add(new Student("Alek", "Petrov", 3.00f));
            students.Add(new Student("Gosho", "Tupchev", 4.750f));
            students.Add(new Student("Sasho", "Masho", 2.00f));
            students.Add(new Student("Dryn", "Dryn", 6.00f));
            students.Add(new Student("Znam", "Li_go", 3.50f));
            students.Add(new Student("Koi", "Otkudee", 4.73f));
            students.Add(new Student("Blagoi", "Mitrev", 4.00f));
            students.Add(new Student("Niki", "Tokmakchiev", 5.50f));
            students.Add(new Student("Jonathan", "Smith", 5.25f));

            var orderedStuds = students.OrderBy(student => student.Grade);
            Console.WriteLine("----- Students -----");
            foreach (var student in orderedStuds)
            {
                Console.WriteLine(student.ToString());
            }

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("sfsdfdfdsf", "Geordfgiev", 123,7));
            workers.Add(new Worker("Aladadadek", "Petfdgfgfgrov", 234,8));
            workers.Add(new Worker("VFASD", "TupGGFGFFGchev", 500,12));
            workers.Add(new Worker("SaFGDGFDGsho", "MGFGasho", 342,10));
            workers.Add(new Worker("DrGDFGyn", "VFDVDrGDFGyn", 562,14));
            workers.Add(new Worker("ZASnSDFDFam", "Li_go", 200,9));
            workers.Add(new Worker("ZXXC", "ADWDW", 800,6));
            workers.Add(new Worker("ZXCBlagoi", "RRMitrev",150, 8));
            workers.Add(new Worker("FGGTGT", "CVXBVB", 190,10));
            workers.Add(new Worker("zxcfvfd", "pkihh", 340,5));

            var descendedWorkers = workers.OrderByDescending(x => x.MoneyPerHour());
            Console.WriteLine("----- Workers -----");
            foreach (var worker in descendedWorkers)
            {
                Console.WriteLine(worker.ToString());
            }

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(orderedStuds);
            mergedList.AddRange(descendedWorkers);

            var final = mergedList.OrderBy(element => element.FirstName).ThenBy(element => element.LastName);
            Console.WriteLine("------ Final Result -----");
            foreach (var item in final)
            {
                Console.WriteLine(item);
            }
        }
    }
}
