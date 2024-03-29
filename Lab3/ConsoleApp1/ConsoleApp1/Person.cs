﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public int Age { get { return age; } set { age = value; } }

        public Person(string firstName, string lastName, int Age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public virtual void View()
        {
            Console.WriteLine($"First Name: {firstName}");
            Console.WriteLine($"Last Name: {lastName}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
