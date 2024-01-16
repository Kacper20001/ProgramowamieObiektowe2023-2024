using CsvHelper;
using System.Globalization;
using System.Text;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "osoby.csv";
            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "Imie,Nazwisko,Ulica,Numer,Kod,Miasto,Kraj,Pesel,Email");
            }

            while (true)
            {
                Console.WriteLine("Naciśnij dowolny klawisz, aby urochmić menu");
                Console.ReadKey();
                Console.Clear();
                Menu();
                int operacja = Convert.ToInt32(Console.ReadLine());
                switch (operacja)
                {

                    case 1:
                        Osoba.WyświetlDane(filePath);
                        break;
                    case 2:
                        Osoba nowaOsoba = Osoba.NowaOsoba();
                        Osoba.DodajOsobe(filePath, nowaOsoba);
                        break;
                    case 3:
                        Console.WriteLine("Podaj pesel osoby, którą chcesz modyfikować");
                        string searchPesel = Console.ReadLine();
                        Osoba.ModyfikujOsobe(filePath, searchPesel);
                        break;
                    case 4:
                        Console.WriteLine("Podaj pesel osoby, którą chcesz usunąć");
                        Osoba.usuńOsobe(filePath);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

            }

        }
        static void Menu()
        {
            Console.WriteLine("Wybierz");
            Console.WriteLine("1.Wyświetl dane");
            Console.WriteLine("2.Dodaj osobę");
            Console.WriteLine("3.Modyfikuj osobę");
            Console.WriteLine("4.Usuń osobę");
            Console.WriteLine("5. Wyjście");
        }
        

    }

}
