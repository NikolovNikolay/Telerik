using System;
using System.Linq;

namespace _1.School
{
    class Student : Human
    {
        private readonly int classNumber;

        public Student(string name, int classNumber)
            : base(name)
        {
            if (classNumber > 0)
                this.classNumber = classNumber;
            else
                throw new ArgumentException("Unappropriate classnumber");
        }

        public int ClassNumber
        {
            get { return this.classNumber; }
        }

    }
}
