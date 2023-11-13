using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Book
    {
        private string title;
        private Person author;
        private DateTime data_wydania;

        public string Title { 
            get { return title; } 
            set { }
        }
        public DateTime Data_wydania
        {
            get { return data_wydania; }
            set { }
        }
        public Book(string title, Person author, DateTime data_wydania)
        {
            this.title = title;
            this.author = author;
            this.data_wydania = data_wydania;
        }
        public void View_books()
        {
            Console.WriteLine($"Tytuł: {title}");
            Console.WriteLine($"Imię autora: {author.FirstName}, nazwisko: {author.LastName}, wiek: {author.Wiek}");
            Console.WriteLine($"Data wydania: {data_wydania}");
        }
    }
}
