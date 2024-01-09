using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string pesel;

        public void SetFirstName(string firstName) {  this.firstName = firstName; }
        public void SetLastName(string lastName) {  this.lastName = lastName; }
        public void SetPesel(string pesel) {  this.pesel = pesel; }

        public Person(string firstName, string lastName, string pesel)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.pesel = pesel;
        }

        public int GetAge()
        {
            if (pesel == null || pesel.Length != 11)
            {
                throw new ArgumentException("Nieprawidłowy PESEL");
            }

            int year = int.Parse(pesel.Substring(0, 2));
            int month = int.Parse(pesel.Substring(2,2));
            int day = int.Parse(pesel.Substring(4, 2));

            if (month > 20)
            {
                month -= 20;
                year += 2000;
            }
            else if (month <= 12)
            {
                year += 1900;
            }
            else 
            { 
                throw new ArgumentException("Pesel spoza zakresu 1900-2100");
            }
            DateTime birthdate = new DateTime(year, month, day);
            DateTime today =  DateTime.Today;
            int age = today.Year - birthdate.Year;
            if (birthdate > today.AddYears(-age)) age -= 1;
            return age;
        }
        public string GetGender()
        {
            string gender;
            int genderNumber = int.Parse(pesel.Substring(10, 1));
            if(genderNumber % 2 == 0) 
            {
                gender = "Women";
            }
            else
            {
                gender = "Men";
            }    
            return gender;
        }
        public abstract string GetEducationInfo();

        public string GetFullName()
        {
            string fullName = firstName + " " + lastName;
            return fullName;
        }
        public abstract bool CanGoAloneToHome();
    }
}
