using System;
using System.Linq;
using System.Text;

namespace _01.Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        // fields of the Student class
        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string pAddress;
        private string mobilePhone;
        private string email;
        private Course? course;
        private Faculty? faculty;
        private Specialty? specialty;
        private University? university;

        //constructors
        public Student(string firstName, string middleName, string lastName, string ssn,string pAddress,
            string mobilePhone, string email, Course? course, Faculty? faculty, Specialty? specialty, University? university)
        {
            try
            {
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;

                if (ssn.Length == 10)
                {
                    this.ssn = ssn;
                }
                else
                    throw new ArgumentException("Invalid social security number");

                this.pAddress = pAddress;
                this.mobilePhone = mobilePhone;

                if (email != null)
                {
                    if (email.Contains("@"))
                    {
                        this.email = email;
                    }
                    else
                        throw new ArgumentException("Invalid e-mail"); 
                }

                this.course = course;
                this.faculty = faculty;
                this.specialty = specialty;
                this.university = university;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }

        public Student(string firstName, string middleName, string lastName, string ssn) :
            this(firstName, middleName, lastName, ssn, null, null, null, null, null, null, null)
        {
        }

        public Student()
        {
        }

        // properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string SSN
        {
            get { return this.ssn; }
            set 
            {
                try
                {
                    if (value.Length == 10)
                    {
                        this.ssn = value;
                    }
                    else
                        throw new ArgumentException("Invalid social security number");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        public string PermanentAddress
        {
            get { return this.pAddress; }
            set { this.pAddress = value; }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set 
            {
                try
                {
                    if (value.Contains("@"))
                    {
                        this.email = value;
                    }
                    else
                        throw new ArgumentException("Invalid e-mail");
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }

        public Course? Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Faculty? Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public University? University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        public Specialty? Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        // Overriding Object Methods
        public override bool Equals(object obj)
        {
            Student otherStudent = obj as Student;
            return this.SSN == otherStudent.SSN;
        }

        public override int GetHashCode()
        {
            return (this.ssn.GetHashCode() + this.firstName.GetHashCode()/2 + this.lastName.GetHashCode()/2);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine("--------  Student Info --------");
            result.AppendFormat("Name: {0} {1} {2}\n\r", this.firstName, this.middleName,this.lastName);
            result.AppendFormat("SSN: {0}\n\r", this.ssn);
            if(!string.IsNullOrWhiteSpace(this.pAddress))
                result.AppendFormat("Address: {0}\n\r", this.pAddress);
            if(!string.IsNullOrWhiteSpace(this.mobilePhone))
                result.AppendFormat("Mobile Phone: {0}\n\r", this.mobilePhone);
            if(!string.IsNullOrWhiteSpace(this.email))
                result.AppendFormat("Email: {0}\n\r", this.email);
            if(this.course != null)
                result.AppendFormat("Course: {0}\n\r", this.course);
            if(this.faculty != null)
                result.AppendFormat("Faculty: {0}\n\r", this.faculty);
            if(this.specialty != null)
                result.AppendFormat("Specialty: {0}\n\r", this.specialty);
            if(this.university != null)
                result.AppendFormat("University: {0}\n\r", this.university);

            return result.ToString();
        }

        public object Clone()
        {
            Student newStud = new Student();

            //newStud = this.MemberwiseClone() as Student;
            //return newStud;

            return new Student(this.firstName, this.middleName, this.lastName, this.ssn, this.pAddress, this.mobilePhone,
                this.email, this.course, this.faculty, this.specialty, this.university);
        }

        public int CompareTo(Student other)
        {
            // comparing two students
            // if they are equal 0 is returned, else their three names and ssn are compared, after which -1 or 1 is returned
            if (Student.Equals(this, other))
                return 0;

            return Student.Equals(new Student[] { this, other }.OrderBy(stud => stud.firstName).ThenBy(stud => stud.middleName).ThenBy(stud => stud.lastName).ThenBy(stud => stud.ssn).First(), this) ? -1 : 1;
        }

        //Overriding operators
        public static bool operator ==(Student main, Student other)
        {
            return main.ssn == other.ssn;
        }

        public static bool operator !=(Student main, Student other)
        {
            return main.ssn != other.ssn;
        }
    }
}