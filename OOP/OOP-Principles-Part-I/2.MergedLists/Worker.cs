using System;
using System.Linq;
using System.Text;

namespace _2.MergedLists
{
    public class Worker : Human
    {
        private float weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, float weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        public float WeekSalary
        {
            get { return this.weekSalary; }
            set { this.weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set { this.workHoursPerDay = value; }
        }

        public float MoneyPerHour()
        {
            float result = this.weekSalary / this.workHoursPerDay;

            return result;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("{0} {1} {2} {3}", FirstName, LastName, weekSalary, workHoursPerDay);

            return builder.ToString();

        }
    }
}
