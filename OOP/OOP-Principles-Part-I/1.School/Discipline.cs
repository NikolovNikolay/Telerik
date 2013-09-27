using System;
using System.Linq;

namespace _1.School
{
    public class Discipline 
    {
        private DisciplineName name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(DisciplineName name, int numOfLectures, int numOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numOfLectures;
            this.numberOfExercises = numOfExercises;
            if (this.numberOfExercises <= 0 || this.numberOfLectures <= 0)
                throw new ArgumentException("Discipline horrarium mismatch");
        }

        public DisciplineName Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int LecturesQuantity
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value > 0)
                {
                    this.numberOfLectures = value;
                }
                else
                    throw new ArgumentException("Discipline horrarium mismatch");
            }
        }

        public int ExercisesQuantity
        {
            get { return this.numberOfExercises; }
            set 
            {
                if (value > 0)
                {
                    this.numberOfExercises = value;  
                }
                else
                    throw new ArgumentException("Discipline horrarium mismatch");
            }
        }
    }
}
