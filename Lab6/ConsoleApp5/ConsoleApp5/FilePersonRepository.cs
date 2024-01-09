using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp5
{
    internal class FilePersonRepository : IPersonRepository
    {
        private readonly string _filePath;

        public FilePersonRepository(string filePath)
        {
            _filePath = filePath;
            if(!File.Exists(_filePath))
            {
                File.Create(filePath).Close();
                File.WriteAllText(filePath, "[]");
            }
        }
        public IEnumerable<Person> GetAllPeople()
        {
            var fileContent = File.ReadAllText(_filePath);
            return JsonConvert.DeserializeObject<List<Person>>(fileContent) ?? new List<Person>();
        }
        public void AddPerson(Person person)
        {
            var people = GetAllPeople().ToList();
            people.Add(person);
            File.WriteAllText(_filePath, JsonConvert.SerializeObject(people));
        }
        public Person GetPersonById(int id)
        {
            return GetAllPeople().FirstOrDefault(p => p.Id == id);
        }

        public void UpdatePerson(Person person)
        {
            var people = GetAllPeople().ToList();
            var index = people.FindIndex(p => p.Id == person.Id);
            if (index != -1)
            {
                people[index] = person;
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(people));
            }
        }

        public void DeletePerson(int id)
        {
            var people = GetAllPeople().ToList();
            var person = people.FirstOrDefault(p => p.Id == id);
            if (person != null)
            {
                people.Remove(person);
                File.WriteAllText(_filePath, JsonConvert.SerializeObject(people));
            }
        }
    }

}
