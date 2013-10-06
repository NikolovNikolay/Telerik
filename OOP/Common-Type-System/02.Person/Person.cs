/* 4.Create a class Person with two fields – name and age. Age can be left
 *   unspecified (may contain null value. Override ToString() to display the
 *   information of a person and if age is not specified – to say so. Write a
 *   program to test this functionality.
*/

using System;
using System.Linq;
using System.Text;

namespace _02.Person
{
    public class Person
    {
        private string name;
        private byte? age;

        public Person(string name, byte? age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name)
            : this(name, null)
        {
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public byte? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("---- Person Info ----");
            result.AppendFormat("Name: {0}\n\r",this.name);
            if (this.age != null)
            {
                result.AppendFormat("Age: {0}\n\r", this.age);
            }
            else
            {
                result.AppendFormat("Age: Not Specified\n\r");
            }

            return result.ToString();
        }
    }
}
