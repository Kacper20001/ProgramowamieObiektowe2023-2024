using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Student : IStudent 
    {   
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string University { get; set; }
        public string Course { get; set; }
        public string Year { get; set; }
        public string Semester {get; set; }

        public Student(string firstName, string lastName, string university, string course, string year, string semester)
        {
            FirstName = firstName;
            LastName = lastName;
            University = university;
            Course = course;
            Year = year;
            Semester = semester;
        }

        public string ReturnFullName()
        {
            return FirstName + " " + LastName;
        }

        public virtual string PrintFullNameAndUniversity() 
        {
            return FirstName + " " + LastName + " - " + Semester + Course + " " + Year + " " + University; 
        }

    }
}
