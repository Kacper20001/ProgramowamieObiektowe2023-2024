using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    internal class Teacher : Student 
    {
        public string title;
        protected List<Student> students;

        public  Teacher(string firstName, string lastName, string pesel, string school, bool CanGoHomeAlone,string title) :
            base(firstName, lastName, pesel, school, CanGoHomeAlone)
        {
            this.title = title;
            this.students = new List<Student>();
        }
        
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);  
        }

        public void WhichStudentCanGoHome(DateTime dateToCheck)
        {
            foreach (Student student in students)
            {
                if (student.CanGoAloneToHome())
                {
                    Console.WriteLine(student.GetFullName());
                }
            }
        }
    }
}
