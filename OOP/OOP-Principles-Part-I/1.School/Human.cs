using System;
using System.Linq;

namespace _1.School
{
    public class Human
    {
        private string name;

        public Human(string name)
        {
            if (name.Length > 4)
            {
                this.name = name;
            }
            else
                throw new ArgumentException("Name too short");
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
