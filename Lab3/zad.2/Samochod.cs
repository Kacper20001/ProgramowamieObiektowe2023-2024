using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad._2
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private string nadwozie;
        private string kolor;
        private int rokProdukcji;
        private int przebieg;

        public string Marka { get { return marka; } set { marka = value; } }
        public string Model { get { return model; } set { model = value; } }
        public string Nadwozie { get { return nadwozie; } set { nadwozie = value; } }
        public string Kolor { get { return kolor; } set { kolor = value; } }
        public int RokProdukcji { get { return rokProdukcji; } set { rokProdukcji = value; } }
        public int Przebieg
        {
            get { return przebieg; }
            set
            {
                if (value >= 0)
                {
                    przebieg = value;
                }
                else
                {
                    Console.WriteLine("Błędna wartość przebiegu. Przebieg nie może być ujemny.");
                }
            }
        }

        public Samochod()
        {
            Console.WriteLine("Podaj markę samochodu");
            Marka = Console.ReadLine();

            Console.WriteLine("Podaj model samochodu");
            Model = Console.ReadLine();

            Console.WriteLine("Podaj typ nadwozia samochodu");
            Nadwozie = Console.ReadLine();

            Console.WriteLine("Podaj kolor samochodu");
            Kolor = Console.ReadLine();

            Console.Write("Podaj rok produkcji ");
            RokProdukcji = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj przebieg");
            Przebieg = Convert.ToInt32(Console.ReadLine());

        }

        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, int przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = przebieg;
        }
        public virtual void WyswietlInformacjeSamochod()
        {
            Console.WriteLine($"Marka samochodu to: {marka}");
            Console.WriteLine($"Model samochodu to: {model}");
            Console.WriteLine($"Kolor samochodu to: {kolor}");
            Console.WriteLine($"Nadwozie samochodu to: {nadwozie}");
            Console.WriteLine($"Rok produkcji samochodu to: {rokProdukcji}");
            Console.WriteLine($"Przebieg samochodu to: {przebieg}");
        }

    }
}
