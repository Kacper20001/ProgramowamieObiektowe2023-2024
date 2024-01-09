using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Osoba : IOsoba
    {
        public string FirstName {get;set;}
        public string LastName { get;set;}

        public Osoba(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public string ReturnFullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
