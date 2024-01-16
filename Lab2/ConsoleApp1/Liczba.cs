using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Liczba
    {
        private int[] cyfry;

        public Liczba(string napis)
        {
            Konwertuj(napis);
        }

        public int[] Konwertuj(string napis)
        {
            cyfry = new int[napis.Length];
            for (int i = 0; i < napis.Length; i++)
            {
                if (char.IsDigit(napis[i]))
                {
                    cyfry[i] = int.Parse(napis[i].ToString());
                }
            }
            return cyfry;
        }
        public BigInteger Scal()
        {
            string scalone = String.Join("", cyfry);
            return BigInteger.Parse(scalone);
        }
        public void Wypisz()
        {
            string liczba = String.Join("", cyfry);
            Console.WriteLine("Liczba:" + liczba);
        }


        public int[] Pomnoz(int x)
        {
            int reszta = 0;
            for (int i = 0; i < cyfry.Length; i++)
            {
                int wynik = cyfry[i] * x + reszta;
                cyfry[i] = wynik % 10;
                reszta = wynik / 10;
            }
            if (reszta > 0)
            {
                int[] tab = new int[cyfry.Length + 1];
                cyfry.CopyTo(tab, 1);
                tab[0] = reszta;
                cyfry = tab;
            }
            return cyfry;
        }

        public static BigInteger SilniaOblicz(Liczba liczbaObj)
        {
            BigInteger liczba = liczbaObj.Scal();
            BigInteger silnia = 1;
            for (BigInteger i = liczba; i > 1; i--)
            {
                silnia *= i;
            }
            Console.WriteLine($"silnia: {silnia}");
            return silnia;
        }
    }
}
