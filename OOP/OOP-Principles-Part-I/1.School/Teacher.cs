using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.School
{
    class Teacher : Human
    {
        private IList<Discipline> disciplines;

        public Teacher(string name, IList<Discipline> setOfDisciplines)
            : base(name)
        {
            this.disciplines = setOfDisciplines;
        }

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
