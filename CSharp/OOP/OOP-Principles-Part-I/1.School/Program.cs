/* 1. We are given a school. In the school there are classes of students.
 * Each class has a set of teachers. Each teacher teaches a set of disciplines.
 * Students have name and unique class number. Classes have unique text
 * identifier. Teachers have name. Disciplines have name, number of lectures 
 * and number of exercises. Both teachers and students are people. Students, 
 * classes, teachers and disciplines could have optional comments (free text block).
 *    Your task is to identify the classes (in terms of  OOP) and their attributes
 * and operations, encapsulate their fields, define the class hierarchy
 * and create a class diagram with Visual Studio.
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.School
{
    class Program
    {
        static List<Teacher> teachers = new List<Teacher>();
        static List<Student> studentsInClass = new List<Student>();

        static void Main()
        {
            SchoolClass simpleClass = new SchoolClass("10 \'A\'", teachers, studentsInClass);
            AddTechersToList();
            AddStudents();
            Console.WriteLine(simpleClass.ToString());

            simpleClass.Teachers.Add(new Teacher("Koceto", new List<Discipline>() 
                                        { new Discipline(DisciplineName.Chemistry,20,20)}));
            simpleClass.Students.Add(new Student("Dimcho", 3));
            Console.WriteLine(simpleClass.ToString());
        }

        private static void AddTechersToList()
        {
            List<Discipline> teacherOneDisciplines = new List<Discipline>();
            teacherOneDisciplines.Add(new Discipline(DisciplineName.Literature, 50, 50));
            teacherOneDisciplines.Add(new Discipline(DisciplineName.BulgarianLanguage, 55, 55));
            teacherOneDisciplines.Add(new Discipline(DisciplineName.Math, 60, 60));

            List<Discipline> teacherTwoDisciplines = new List<Discipline>();
            teacherTwoDisciplines.Add(new Discipline(DisciplineName.Arts, 40, 45));
            teacherTwoDisciplines.Add(new Discipline(DisciplineName.Music, 40, 40));
            teacherTwoDisciplines.Add(new Discipline(DisciplineName.Biology, 60, 60));

            List<Discipline> teacherThreeDisciplines = new List<Discipline>();
            teacherThreeDisciplines.Add(new Discipline(DisciplineName.Physics, 40, 45));
            teacherThreeDisciplines.Add(new Discipline(DisciplineName.Chemistry, 40, 40));

            teachers.Add(new Teacher("Pesho", teacherOneDisciplines));
            teachers.Add(new Teacher("Kircho", teacherTwoDisciplines));
            teachers.Add(new Teacher("Ginka", teacherThreeDisciplines));
        }

        private static void AddStudents()
        {
            studentsInClass.Add(new Student("Stoyan", 10));
            studentsInClass.Add(new Student("Aleksandra", 1));
            studentsInClass.Add(new Student("Gavrail", 4));
        }
    }
}
