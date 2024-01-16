using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class Reader : Person
    {
        private List<Book> readBooks;
        public List<Book> ReadBooks
        {
            get { return readBooks; }
        }

        public Reader(string firstName, string lastName, int age) :
                base(firstName, lastName, age)
        {
            readBooks = new List<Book>();
        }
        public void AddBook(Book book)
        {
            readBooks.Add(book);
        }
        public void ViewBooks()
        {
            Console.WriteLine("Lista przeczytanych książek:");
            foreach (Book book in readBooks)
            {
                Console.WriteLine(book.Title);
            }
        }

        public override void View()
        {
            base.View();
            ViewBooks();
        }

    }
}
