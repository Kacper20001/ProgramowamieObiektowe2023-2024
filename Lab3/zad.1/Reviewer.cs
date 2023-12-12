using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._1
{
    internal class Reviewer : Reader
    {
        private Random random;
        public Reviewer(string firstName, string lastName, int age) :
            base(firstName, lastName, age)
        {
            random = new Random();
        }

        public void PrintReviews()
        {
            Console.WriteLine($"Reviewer: {FirstName} {LastName}");
            Console.WriteLine($"Review:");

            foreach (Book book in ReadBooks)
            {
                int rating = random.Next(0, 6);
                Console.WriteLine($"{book.Title} - ocena: {rating}");
            }
        }

    }        
}
