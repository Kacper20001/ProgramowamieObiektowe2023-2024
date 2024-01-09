namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new FilePersonRepository("people.json");

            repository.AddPerson(new Person { Id = 1, Name = "Jan Kowalski", Age = 30 });
            repository.AddPerson(new Person { Id = 2, Name = "Anna Nowak", Age = 25 });

            foreach (var person in repository.GetAllPeople())
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }

            repository.UpdatePerson(new Person { Id = 1, Name = "Jan Kowalski", Age = 31 });

            repository.DeletePerson(2);

            foreach (var person in repository.GetAllPeople())
            {
                Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Age: {person.Age}");
            }
        }
    }
}
