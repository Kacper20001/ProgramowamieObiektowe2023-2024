using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SamochodOsobowy : Samochod
    {
        private double waga;
        private double pojemnosc;
        private int iloscOsob;

        public double Waga
        {
            get { return waga; }
            set
            {
                if (value >= 2.0 && value <= 4.5)
                {
                    waga = value;
                }
                else
                {
                    Console.WriteLine("Błędna wartość dla wagi. Waga powinna być z przedziału 2 t – 4,5 t.");
                }
            }
        }
        public double Pojemnosc
        {
            get { return pojemnosc; }
            set
            {
                if (value >= 0.8 && value <= 3.0)
                {
                    pojemnosc = value;
                }
                else
                {
                    Console.WriteLine("Błędna wartość dla pojemności silnika. Pojemność silnika powinna być z przedziału 0,8-3,0.");
                }
            }
        }
        public int IloscOsob { get { return iloscOsob; } set { iloscOsob = value; } }

        public SamochodOsobowy() :
            base()
        {
            Console.WriteLine("Podaj wage samochodu");
            Waga = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj pojemnosc silnika");
            Pojemnosc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj ilość miejsc");
            IloscOsob = Convert.ToInt32(Console.ReadLine());
        }

        public override void WyswietlInformacjeSamochod()
        {
            base.WyswietlInformacjeSamochod();
            Console.WriteLine($"Waga samochodu wynosi: {waga}");
            Console.WriteLine($"Pojemnosc silnika samochodu wynosi: {pojemnosc}");
            Console.WriteLine($"Ilosc miejsc w samochodzie wynosi: {iloscOsob}");
        }
    }
}
