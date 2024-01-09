using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal static class OsobaExtensions
    {
        public static void PrintPeople(this List<IOsoba> osoby)
        {
            foreach (var o in osoby)
            {
                Console.WriteLine(o.ReturnFullName());
            }
        }

        public static void SortPeopleByLastName(this List<IOsoba> osoby)
        {
            osoby.Sort((osoba1, osoba2) => osoba1.LastName.CompareTo(osoba2.LastName));
        }
    }
}
