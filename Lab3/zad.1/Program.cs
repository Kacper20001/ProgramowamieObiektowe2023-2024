namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person author1 = new Person("Imię_autora1", "Nazwisko_autora1", 30);
            Person author2 = new Person("Imię_autora2", "Nazwisko_autora2", 50);

            Book book1 = new Book("Książka 1", author1, new DateTime(2011, 1, 15));
            Book book2 = new Book("Książka 2", author2, new DateTime(2012, 2, 17));
            Book book3 = new Book("Książka 3", author1, new DateTime(2013, 3, 1));
            Book book4 = new Book("Książka 4", author2, new DateTime(2014, 11, 23));
            Book book5 = new Book("Książka 5", author1, new DateTime(2015, 7, 9));

            Reader reader1 = new Reader("Imię_czytelnika1", "Nazwisko_czytelnika1", 20);
            Reader reader2 = new Reader("Imię_czytelnika2", "Nazwisko_czytelnika2", 34);

            reader1.AddReadBook(book1);
            reader1.AddReadBook(book2);
            reader1.AddReadBook(book3);

            reader2.AddReadBook(book4);
            reader2.AddReadBook(book5);

            reader1.ViewBook();
            reader2.View_booK_person();
        }
    }
}