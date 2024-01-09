using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Osoba
    {
        public string firstName;
        public string lastName;
        public int wiek;
        public List<string> hobby;

        public Osoba(string firstName, string lastName, int wiek, List<string> hobby) 
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wiek = wiek;
            this .hobby = hobby;   
        }
        public static Osoba DeepCopy(Osoba obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Obiekt nie może nyć null");
            }
            List<string> newHobbyList = new List<string>(obj.hobby);
            return new Osoba(obj.firstName, obj.lastName, obj.wiek, newHobbyList);
        }
    }
}
