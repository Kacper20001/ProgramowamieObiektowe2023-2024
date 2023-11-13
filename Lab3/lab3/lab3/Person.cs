using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int wiek;

        public string FirstName
        {
            get { return firstName; }
            set { }
        }

        public string LastName
        {
            get { return lastName; }
            set { }
        }
        public int Wiek
        {
            get { return wiek; }
            set { }
        }

        public Person(string firstName, string lastName, int wiek)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.wiek = wiek;
        }

        public void View()
        {
            Console.WriteLine($"Imię: {firstName}");
            Console.WriteLine($"Nazwisko: {lastName}");
            Console.WriteLine($"Wiek: {wiek}");
        }
    }
}
