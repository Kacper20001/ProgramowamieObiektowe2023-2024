using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Reader: Person
    {
        private List<Book> readBooks;

        public Reader(string firstName, string lastName, int wiek) :
            base(firstName, lastName, wiek)
        {
            readBooks = new List<Book>();
        }

        public void AddReadBook (Book book)
        {
            readBooks.Add(book);
        }

        public void ViewBook()
        {
            Console.WriteLine($"Lista przeczytanych książek przez użykownika: {FirstName}-{LastName}-{Wiek}");
            foreach (Book book in readBooks)
            {
                Console.WriteLine(book.Title);
            }
        }
        public void View_booK_person() 
        {
            base.View();
            ViewBook();
        }
    }
}
