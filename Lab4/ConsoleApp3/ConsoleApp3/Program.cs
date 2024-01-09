namespace ConsoleApp3
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba("Jan", "Kowalski");
            Osoba osoba2 = new Osoba("Zbigniew", "Nowak");
            Osoba osoba3 = new Osoba("Wojtek", "Bartochowski");

            List<IOsoba> osoby = new List<IOsoba>();

            osoby.Add(osoba1);
            osoby.Add(osoba2);
            osoby.Add(osoba3);
/*
            osoby.PrintPeople();
            osoby.SortPeopleByLastName();
            osoby.PrintPeople();*/

            Student student1 = new Student("Marek", "Kowalski", "WSIiZ", "IID-P", "2024", "4");
            Console.WriteLine(student1.PrintFullNameAndUniversity());

            StudentWSIiZ studentWsIiZ1 = new StudentWSIiZ("Janek", "Wiśniewski", "WSIiZ", "IID", "2024", "4");
            Console.WriteLine(studentWsIiZ1.PrintFullNameAndUniversity());



        }
    }
}
