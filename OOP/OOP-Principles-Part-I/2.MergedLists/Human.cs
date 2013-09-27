using System;
using System.Linq;

namespace _2.MergedLists
{
    public abstract class Human
    {
        private string firstName;

        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if(value.Length > 4)
                    this.firstName = value;
                else
                    throw new ArgumentException("Input some correct firstname");
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length > 4)
                {
                    this.lastName = value;
                }
                else
                    throw new ArgumentException("Input some correct lastname");
            }
        }

        public abstract override string ToString();
    }
}
