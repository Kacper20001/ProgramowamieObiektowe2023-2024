using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Osoba
    {
        private string _pesel;
        private string _email;

        public string imie { get; set; }
        public string nazwisko { get; set; }
        public Adres adres { get; set; }
        public string pesel
        {
            get => _pesel;
            set
            {
                if (value.Length == 11 && value.All(char.IsDigit))
                {
                    _pesel = value;
                }
                else
                {
                    throw new ArgumentException("Pesel musi mieć 11 znaków");
                }
            }
        }
        public string email
        {
            get => _email;
            set
            {
                if (Regex.IsMatch(value, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    _email = value;
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowy  email");
                }
            }
        }
        public Osoba(string imie, string nazwisko, Adres adres, string pesel, string email)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.pesel = pesel;
            this.email = email;
        }


        public Osoba()
        {
        }

        public static List<Osoba> WczytajRekordy(string filePath)
        {
            var records = new List<Osoba>();
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    csv.Context.RegisterClassMap<OsobaMap>();
                    records = csv.GetRecords<Osoba>().ToList();
                }
            }
            return records;
        }
        public static void ZapiszRekordy(string filePath, List<Osoba> records)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Context.RegisterClassMap<OsobaMap>();
                csv.WriteRecords(records);
            }
        }
        public static void WyświetlDane(string filePath)
        {
            using (var reader = new StreamReader(filePath))

            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Osoba>().ToList();

                foreach (var osoba in records)
                {
                    Console.WriteLine($"Imię: {osoba.imie}, Nazwisko: {osoba.nazwisko}, Adres: {osoba.adres.ulica} {osoba.adres.numer}, {osoba.adres.kod} {osoba.adres.miasto}, PESEL: {osoba.pesel}, Email: {osoba.email}");
                }
            }

        }

        public static void DodajOsobe(string filePath, Osoba nowaOsoba)
        {
            try
            {
                var records = WczytajRekordy(filePath);
                records.Add(nowaOsoba);
                ZapiszRekordy(filePath, records);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
        }

        public static void ModyfikujOsobe(string filePath, string searchPesel)
        {
            try
            {
                var records = WczytajRekordy(filePath);

                var osoba = records.FirstOrDefault(o => o.pesel == searchPesel);
                if (osoba != null)
                {
                    Console.WriteLine("Podaj nowe imię:");
                    osoba.imie = Console.ReadLine();

                    Console.WriteLine("Podaj nowe nazwisko:");
                    osoba.nazwisko = Console.ReadLine();

                    Console.WriteLine("Podaj nowy email:");
                    osoba.email = Console.ReadLine();

                    Console.WriteLine("Podaj nową ulicę:");
                    osoba.adres.ulica = Console.ReadLine();

                    Console.WriteLine("Podaj nowy numer:");
                    osoba.adres.numer = Console.ReadLine();

                    Console.WriteLine("Podaj nowy kod pocztowy:");
                    osoba.adres.kod = Console.ReadLine();

                    Console.WriteLine("Podaj nowe miasto:");
                    osoba.adres.miasto = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Osoba o podanym PESEL nie została znaleziona.");
                }

                ZapiszRekordy(filePath, records);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Wystąpił błąd: " + ex.Message);
            }
        }
        public static void usuńOsobe(string filePath)
        {
            try
            {
                Console.Write("Podaj PESEL osoby do usunięcia:");
                string pesel = Console.ReadLine();
                var records = WczytajRekordy(filePath);

                var osobaDoUsuniecia = records.FirstOrDefault(o => o.pesel == pesel);
                if (osobaDoUsuniecia != null)
                {
                    records.Remove(osobaDoUsuniecia);
                    ZapiszRekordy(filePath, records);
                    Console.WriteLine("Osoba została usunięta.");
                }
                else
                {
                    Console.WriteLine("Nie znaleziono osoby o podanym PESEL.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }

        public static Osoba NowaOsoba()
        {
            try
            {
                Console.WriteLine("Podaj imię:");
                string imie = Console.ReadLine();

                Console.WriteLine("Podaj nazwisko:");
                string nazwisko = Console.ReadLine();

                Console.WriteLine("Podaj ulicę:");
                string ulica = Console.ReadLine();

                Console.WriteLine("Podaj numer:");
                string numer = Console.ReadLine();

                Console.WriteLine("Podaj kod pocztowy:");
                string kod = Console.ReadLine();

                Console.WriteLine("Podaj miasto:");
                string miasto = Console.ReadLine();

                Console.WriteLine("Podaj PESEL:");
                string pesel = Console.ReadLine();
                if (pesel.Length != 11 || !pesel.All(char.IsDigit))
                {
                    throw new FormatException("Pesel musi mieć 11 cyfr.");
                }

                Console.WriteLine("Podaj email:");
                string email = Console.ReadLine();

                Adres adres = new Adres(ulica, numer, kod, miasto);

                Osoba nowaOsoba = new Osoba(imie, nazwisko, adres, pesel, email);
                return new Osoba(imie, nazwisko, adres, pesel, email);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Pola nie mogą być null: {ex.Message}");
                return null;
            }
        }

    }
}
