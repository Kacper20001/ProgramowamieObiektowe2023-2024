using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class StudentWSIiZ : Student
    {
        public StudentWSIiZ(string firstName, string lastName, string university, string course, string year, string semester)
        : base(firstName, lastName, university, course, year, semester)
        {
        }
        public override string PrintFullNameAndUniversity()
        {
            return $"WSIiZ: {FirstName} {LastName} - {Semester} {Course} {Year} {University}";
        }
    }
}
