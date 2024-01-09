using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Osoba :ICloneable
    {
        public string firstName;
        public string lastName;
        public int wiek;
        public List<string> hobby;

        public Osoba(string firstName, string lastName, int wiek, List<string>hobby)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wiek = wiek;
            this.hobby = hobby;
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
