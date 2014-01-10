using System;
using System.Linq;

namespace _1.School
{
    class Student : Human
    {
        // field
        private readonly int classNumber;

        // constructor
        public Student(string name, int classNumber)
            : base(name)
        {
            if (classNumber > 0)
                this.classNumber = classNumber;
            else
                throw new ArgumentException("Unappropriate classnumber");
        }

        // property
        public int ClassNumber
        {
            get { return this.classNumber; }
        }

    }
}
