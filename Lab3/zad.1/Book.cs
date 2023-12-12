using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class Book
    {
        protected string title;
        private Person author;
        private DateTime dateOfPublication;

        public string Title {  get { return title; } set {  title = value; } }
        public DateTime DateOfPublication { get {  return dateOfPublication; } set {  dateOfPublication = value; } }

        public Book(string title, Person author, DateTime dateOfPublication)
        {
            Title = title;
            this.author = author;
            DateOfPublication = dateOfPublication;
        }
        public virtual void View()
        {
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Date of publication: {dateOfPublication}");
            Console.WriteLine($"First name: {author.FirstName}");
            Console.WriteLine($"Last name: {author.LastName}");
            Console.WriteLine($"Age: {author.Age}");

        }

    }
}
