using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    class SchoolClass
    {
        // fields
        private IList<Teacher> teachers;
        private readonly string uniqueIdentificator;
        private IList<Student> students;

        // constructor
        public SchoolClass(string uniqueID, IList<Teacher> teachers, IList<Student> students)
        {
            this.uniqueIdentificator = uniqueID;
            this.teachers = teachers;
            this.students = students;
        }


        // properties
        public IList<Teacher> Teachers
        {
            get { return this.teachers; }
            set { this.teachers = value; }
        }

        public IList<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public string ID
        {
            get { return this.uniqueIdentificator; }
        }

        // overriding the ToString method
        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendFormat("..:: Representing {0} class ::..\n\r", this.uniqueIdentificator);
            result.AppendFormat("-------- Teachers ----------\n\r");
            foreach (var teacher in teachers)
            {
                result.AppendFormat("{0}: ", teacher.Name);
                foreach (var discipline in teacher.Disciplines)
                {
                    result.AppendFormat("{0} ",discipline.Name);
                }
                result.Append("\n\r");
            }

            var sortedStudents = this.students.OrderBy(student => student.ClassNumber);
            result.AppendLine("-------- Students ----------");
            foreach (var student in sortedStudents)
            {
                result.AppendFormat("{0} {1}\n\r", student.ClassNumber, student.Name);
            }

            return result.ToString().Trim();
        }
    }
}
