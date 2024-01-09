using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public interface IPersonRepository
    {
        void AddPerson(Person person);
        IEnumerable<Person> GetAllPeople();
        Person GetPersonById(int id);
        void UpdatePerson(Person person);
        void DeletePerson(int id);
    }
}
