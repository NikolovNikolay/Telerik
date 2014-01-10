using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.School
{
    class Teacher : Human
    {
        // field
        private IList<Discipline> disciplines;

        // constructor
        public Teacher(string name, IList<Discipline> setOfDisciplines)
            : base(name)
        {
            this.disciplines = setOfDisciplines;
        }

        // property
        public IList<Discipline> Disciplines
        {
            get { return this.disciplines; }
            set
            {
                this.disciplines = value;
            }
        }

    }
}
