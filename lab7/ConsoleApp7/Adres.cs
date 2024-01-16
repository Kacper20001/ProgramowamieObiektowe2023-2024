using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Adres
    {
        public string ulica { get; set; }
        public string numer { get; set; }
        public string kod { get; set; }

        public string miasto { get; set; }

        public Adres()
        {

        }
        public Adres(string ulica, string numer, string kod, string miasto)
        {
            this.ulica = ulica;
            this.numer = numer;
            this.kod = miasto;
            this.miasto = miasto;
        }


    }
}
