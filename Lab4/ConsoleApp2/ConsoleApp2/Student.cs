using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Student : Person
    {
        protected string school;
        protected bool canGoHomeAlone;


        public Student(string firstName, string lastName, string pesel ,string school, bool canGoHomeAlone) :
            base(firstName,lastName, pesel)
        {
            this.school = school;
            this.canGoHomeAlone= canGoHomeAlone;
        }

        public void SetSchool(string school)
        {
            this.school = school;
        }

        public void ChangeSchool(string newSchool)
        {
            school = newSchool;
        }
        public void SerCanGoHomeAlone(bool canGoHomeAlone)
        {
            this.canGoHomeAlone = canGoHomeAlone;
        }
        public override string GetEducationInfo()
        {
            return "School: " + school;
        }
        public override bool CanGoAloneToHome()
        {
            if(GetAge() < 12 && !canGoHomeAlone)  
            {
                return false;
            }
            return true;
        }

    }
}
