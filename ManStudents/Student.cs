using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManStudents
{
    public class Student : IComparable, ICloneable, IMan
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string MiddleName { get; set; }

        public Student(string firstName, string lastName, string miggleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = miggleName;
        }        
        public string GetParams()
        {
            return FirstName + " " + LastName + " " + MiddleName;
        }

        public object Clone()
        {
            return new Student(FirstName, LastName, MiddleName);
        }

        public int CompareTo(object obj)
        {
            Father temp = (Father)obj;
            if (this.LastName == temp.LastName) return 0;
            else return -1;
        }

    }

    public class Father : IComparable, ICloneable, IMan
    {
       public string FirstName { get; set; }
       public string LastName { get; set; }
       public string MiddleName { get; set; }

        public Father(string firstName, string lastName, string miggleName)
        {
            FirstName = firstName;
            LastName = lastName;
            MiddleName = miggleName;
        }

        public string GetParams()
        {
            return FirstName + " " + LastName + " " + MiddleName;
        }

        public object Clone()
        {
            return new Father(FirstName, LastName, MiddleName);
        }

        public int CompareTo(object obj)
        {
            Student temp = (Student)obj;
            if (this.LastName == temp.LastName) return 0;
            else return -1;
        }
    }
}
