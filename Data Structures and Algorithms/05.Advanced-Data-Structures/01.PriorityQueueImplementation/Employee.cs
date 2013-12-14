
namespace PriorityQueueImplementation
{
    using System;
    using System.Linq;

    public class Employee : IComparable<Employee>
    {
        public double Priority { get; private set; } // the lower the value of the priority - the higher the priority 
        public string Name { get; private set; }

        public Employee(string name, double priority)
        {
            this.Priority = priority;
            this.Name = name;
        }

        public override string ToString()
        {
            return "Employee: ( Name: " + this.Name + " | Priority: " + this.Priority + " );";
        }

        public int CompareTo(Employee other)
        {
            if (this.Priority < other.Priority) return -1;
            else if (this.Priority > other.Priority) return 1;
            else return 0;
        }
    }
}
