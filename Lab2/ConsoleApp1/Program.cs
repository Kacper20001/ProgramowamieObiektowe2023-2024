using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using zad1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Licz liczba = new Licz(5);
                liczba.odejmij(3);
                liczba.Wypisz();
                liczba.dodaj(10);
                liczba.Wypisz();

                double[] liczby = new double[] { 5, 3, 6, 10, 7 };
                Sumator sumator = new Sumator(liczby);
                sumator.Suma();
                sumator.SumaPodziel2();
                sumator.IleElementów();
                sumator.WypiszElementy();
                sumator.WypiszElementyIndex(2, 4);
                sumator.WypiszElementyIndex(-10, 100);

                Data data2 = new Data(2020, 11, 10);
                data2.PrzesunTydzien();
                Console.WriteLine(data2.ToString());
                data2.CofnijTydzien();
                Console.WriteLine(data2.ToString());
                data2.UstawBiezacaDate();
                Console.WriteLine(data2.ToString());


                Liczba liczba1 = new Liczba("12");
                Liczba liczba2 = new Liczba("5");
                liczba1.Wypisz();
                liczba1.Pomnoz(2);
                liczba1.Wypisz();

                Liczba.SilniaOblicz(liczba2);
            }            
        }
    }
}
