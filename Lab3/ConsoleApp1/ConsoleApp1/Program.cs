namespace zad._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> peopleList = new List<Person>();

            Person author1 = new Person("Jan", "Kowalski", 32);
            Person author2 = new Person("Zbigniew", "Nowak", 45);
            /*            author1.View();
            */
            Book book1 = new Book("Book1", author1, new DateTime(2011, 1, 15));
            Book book2 = new Book("Book2", author2, new DateTime(2009, 7, 17));
            Book book3 = new Book("Book3", author1, new DateTime(2020, 10, 18));
            Book book4 = new Book("Book4", author2, new DateTime(2022, 11, 23));
            /*            book2.View();
            */

            Reader reader1 = new Reader("Magdalena", "Kowalska", 23);
            Reader reader2 = new Reader("Kasia", "Jasińska", 43);
            Reader reader3 = new Reader("Kacper", "Wasilewski", 22);

            reader1.AddBook(book1);
            reader1.AddBook(book2);
            reader2.AddBook(book3);
            reader2.AddBook(book4);
            reader3.AddBook(book2);

            /*            reader1.ViewBook();
             *            
            */
            Person o = new Reader("Kuba", "Błaszczyk", 50);
            /*            o.View();
            */
            Reviewer reviewer1 = new Reviewer("Rafał", "Szpunar", 73);
            Reviewer reviewer2 = new Reviewer("Olivia", "Kielar", 80);

            reviewer1.AddBook(book1);
            reviewer1.AddBook(book2);
            reviewer1.AddBook(book3);

            reviewer2.AddBook(book2);

            /*            reviewer1.PrintReviews();*/

            peopleList.Add(reader1);
            peopleList.Add(reader2);
            peopleList.Add(reader3);
            peopleList.Add(reviewer1);
            peopleList.Add(reviewer2);


            AdventureBook adventureBook = new AdventureBook("AdventureBook1", new Person("Author1", "LastName1", 30), new DateTime(2011, 1, 15), "Character1");
            DocumentaryBook documentaryBook = new DocumentaryBook("DocumentaryBook1", new Person("Author2", "LastName2", 40), new DateTime(2009, 7, 17), "Topic1");
            reader1.AddBook(adventureBook);
            reader2.AddBook(documentaryBook);
            reader1.ViewBooks();
        }
    }
}
