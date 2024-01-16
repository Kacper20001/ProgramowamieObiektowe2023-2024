using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper.Configuration;

namespace ConsoleApp7
{
    internal sealed class OsobaMap : ClassMap<Osoba>
    {
        internal OsobaMap()
        {
            Map(m => m.imie).Name("imie");
            Map(m => m.nazwisko).Name("nazwisko");
            Map(m => m.adres.ulica).Name("ulica");
            Map(m => m.adres.numer).Name("numer");
            Map(m => m.adres.kod).Name("kod");
            Map(m => m.adres.miasto).Name("miasto");
            Map(m => m.pesel).Name("pesel");
            Map(m => m.email).Name("email");
        }
    }
}
