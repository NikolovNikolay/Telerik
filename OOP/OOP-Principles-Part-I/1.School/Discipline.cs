using System;
using System.Linq;

namespace _1.School
{
    public class Discipline 
    {
        // class's fields 
        private DisciplineName name;
        private int numberOfLectures;
        private int numberOfExercises;

        // class's constructor. Exception is being thrown if invalid parameters are entered       
        public Discipline(DisciplineName name, int numOfLectures, int numOfExercises)
        {
            this.name = name;
            this.numberOfLectures = numOfLectures;
            this.numberOfExercises = numOfExercises;
            if (this.numberOfExercises <= 0 || this.numberOfLectures <= 0)
                throw new ArgumentException("Discipline horrarium mismatch");
        }

        // properties
        public DisciplineName Name
        {
            get { return this.name; }
        }


        // the following properties's values are validated in the properties as well in the constructor, in case of changing values afterwards
        public int LecturesQuantity
        {
            get { return this.numberOfLectures; }
            set
            {
                if (value > 0)
                    this.numberOfLectures = value;
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
