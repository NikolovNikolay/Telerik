using System;
using System.Linq;

namespace _1.School
{
    public class Human
    {
        // field
        private string name;

        // class's constructor
        public Human(string name)
        {
            if (name.Length > 4)
            {
                this.name = name;
            }
            else
                throw new ArgumentException("Name too short");
        }

        // property
        public string Name
        {
            get { return this.name; }
            set 
            { 
                if(value.Length > 4)
                    this.name = value
                else 
                    throw new ArgumentException("Name too short");
            }
        }
    }
}
