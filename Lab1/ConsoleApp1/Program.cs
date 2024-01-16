using System.Xml.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Napisz program obliczający wyróżnik delta i pierwiastki trójmianu kwadratowego.
            //zad1();

            /*            2.Napisz kalkulator obliczający: sumę, różnicę, iloczyn, iloraz, potęgę, pierwiastek, oraz wartości
                          funkcji trygonometrycznych dla zadanego kąta.Użyj biblioteki Math np. Math.Sin(2.5).Proszę
                          pamiętać, że wartości kąta podawane do funkcji mierzone są miarą łukową. Wyniki działania
                          algorytmów wyświetlaj na konsoli. Do obsługi menu proszę użyć konstrukcji switch-case oraz
                          pętli while.*/
             zad2();

            /*            Napisz program umożliwiający wprowadzanie 10 - ciu liczb rzeczywistych do tablicy.Następnie
                          utwórz następujące funkcjonalności używając pętli for:
                          • Wyświetlanie tablicy od pierwszego do ostatniego indeksu.
                          • Wyświetlanie tablicy od ostatniego do pierwszego indeksu.
                          • Wyświetlanie elementów o nieparzystych indeksach.
                          • Wyświetlanie elementów o parzystych indeksach.*/
            // zad3();

            /*            4.Napisz program umożliwiający wprowadzanie 10 - ciu liczb.Dla wprowadzonych liczb wykonaj
                        odpowiednie algorytmy:
                        • oblicz sumę elementów tablicy,
                        • oblicz iloczyn elementów tablicy,
                        • wyznacz wartość średnią,
                        • wyznacz wartość minimalną,
                        wyznacz wartość maksymalną*/
            //zad4();
            /*
                        5.Napisz program wyświetlający liczby od 20 - 0, z wyłączeniem liczb { 2,6,9,15,19}. Do realizacji
                        zadania wyłączenia użyj instrukcji continue;
            */
            //zad5();
            /*
                        6.Napisz program, który w nieskończoność pyta użytkownika o liczby całkowite. Pętla
                        nieskończona powinna się zakończyć gdy użytkownik wprowadzi liczbę mniejszą od zera. Do
                        opuszczenia pętli nieskończonej użyj instrukcji break. */
            // zad6();

            /*            7.Napisz program umożliwiający wprowadzanie n liczb oraz sortujący te liczby metodą
                        bąbelkową lub wstawiania.Wyniki wyświetlaj na konsoli.*/
            // zad7();

        }
        static double inputDouble()
        {
            Console.WriteLine("Podaj wartość");
            double a = Convert.ToDouble(Console.ReadLine());
            return a;
        }
        static double delta(double a, double b, double c)
        {
            double deltaValue = (b * b - 4 * a * c);
            Console.WriteLine($"Delta = {deltaValue}");
            return deltaValue;
        }
        static void obliczPierwiastki(double a, double b, double deltaValue)
        {
            if (deltaValue == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Równanie posiada tylko jeden pierwiastek, który wynosi: {x}");
            }
            else if (deltaValue > 0)
            {
                double x1 = (-b - Math.Sqrt(deltaValue)) / (2 * a);
                double x2 = (-b + Math.Sqrt(deltaValue)) / (2 * a);
                Console.WriteLine($"Pierwiastkami trójmainu kwadratowego są: x1 = {x1} oraz x2 = {x2}");
            }
            else
            {
                Console.WriteLine("Równanie nie ma rozwiązania");
            }
        }
        static void rownanieLiniowe(double b, double c)
        {
            Console.WriteLine($"Jest to równanie liniowe postaci {b}x + {c} = 0");
            if (b == 0)
            {
                if (c == 0)
                {
                    Console.WriteLine("Równanie ma nieskończenie wiele rozwiązań");
                }
                else
                {
                    Console.WriteLine("Równanie nie ma rozwiązania");
                }
            }
            else
            {
                double x = -c / b;
                Console.WriteLine($"Rozwiązanie równania liniowego wynosi: {x}");
            }
        }
        static void zad1()
        {
            Console.WriteLine("Program obliczający deltę oraz pierwiastki równania kwadratowego w posaci: ax^2 * bx + c ");

            Console.WriteLine("Podaj a");
            double a = inputDouble();

            Console.WriteLine("Podaj b");
            double b = inputDouble();

            Console.WriteLine("Podaj c");
            double c = inputDouble();
            double deltaValue = delta(a, b, c);

            if (a == 0)
            {
                rownanieLiniowe(b, c);
            }
            else
            {
                Console.WriteLine($"Twoje równanie jest postaci {a}x^2 + {b}x + {c}");

                delta(a, b, c);
                obliczPierwiastki(a, b, deltaValue);
            }

        }

        static void View()
        {
            Console.WriteLine("Wybierz operację");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Roznica");
            Console.WriteLine("3. Iloczyn");
            Console.WriteLine("4. Iloraz");
            Console.WriteLine("5. Potęgowanie");
            Console.WriteLine("6. Pierwiastek");
            Console.WriteLine("7. Trygonometria - sinus");
            Console.WriteLine("8. Wyjście");
            Console.WriteLine("Twój wybór");
        }

        static void Suma(double a, double b)
        {
            double suma = a + b;
            Console.WriteLine($"Suma wynosi {suma}.");
        }
        static void Roznica(double a, double b)
        {
            double roznica = a - b;
            Console.WriteLine($"Róznica wynosi: {roznica}.");
        }
        static void Iloczyn(double a, double b)
        {
            double iloczyn = a * b;
            Console.WriteLine($"Iloczyn wynosi: {iloczyn}");
        }
        static void Iloraz(double a, double b)
        {
            double iloraz = a / b;
            Console.WriteLine($"Iloraz wynosi: {iloraz}");
        }
        static void Potega(double a, double b)
        {
            double potega = Math.Pow(a, b);
            Console.WriteLine($"Potęga wynosi: {potega}");
        }
        static void Pierwiastek(double a)
        {
            double pierwiastek = Math.Sqrt(a);
            Console.WriteLine($"Pieiastek wynos: {pierwiastek}");
        }
        static void Sinus(double a)
        {
            double rad = a * (Math.PI / 180);
            double sinus = Math.Sin(rad);
            Console.WriteLine($"Sinus kąta wynosi: {sinus}");
        }

        static void zad2()
        {
            while (true)
            {
                Console.WriteLine("Naciśnij dowolny przycisk, aby rozpocząć.");
                Console.ReadKey();
                Console.Clear();
                View();
                int operacja = Convert.ToInt32(Console.ReadLine());
                double a, b;

                switch (operacja)
                {
                    case 1:
                        a = inputDouble();
                        b = inputDouble();
                        Suma(a, b);
                        break;
                    case 2:
                        a = inputDouble();
                        b = inputDouble();
                        Roznica(a, b);
                        break;
                    case 3:
                        a = inputDouble();
                        b = inputDouble();
                        Iloczyn(a, b);
                        break;
                    case 4:
                        a = inputDouble();
                        b = inputDouble();
                        Iloraz(a, b);
                        break;
                    case 5:
                        a = inputDouble();
                        b = inputDouble();
                        Potega(a, b);
                        break;
                    case 6:
                        a = inputDouble();
                        Pierwiastek(a);
                        break;
                    case 7:
                        a = inputDouble();
                        Sinus(a);
                        break;
                    case 8:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wprowadzono numer spoza listy wyboru");
                        break;
                }

            }
        }
        static void WyswietlOdPierwszego(double[] tablica)
        {
            Console.WriteLine("Wyświetlanie elementów tablicy od pierwszego do ostatniego indeksu");
            for (int i = 0; i < tablica.Length; i++)
            {
                Console.WriteLine(tablica[i]);
            }
            /*foreach (int item in tablica)
            {
                Console.WriteLine(item);
            }*/
        }
        static void WyswietlOdOstatniego(double[] tablica)
        {
            Console.WriteLine("Wyświetlanie elementów tablicy od ostatniego do pierwszego indekus");
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(tablica[i]);
            }
        }
        static void WyswietlNieparzyste(double[] tablica)
        {
            Console.WriteLine("Wyświetlaie elementów tablicy o nieparzystych indeksach");
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(tablica[i]);
                }
            }
        }
        static void WyswietlParzyste(double[] tablica)
        {
            Console.WriteLine("Wyświetlanie elementów tablicy o parzystych indeksach");
            for (int i = 0; i < tablica.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(tablica[i]);
                }
            }
        }
        static void zad3()
        {
            double[] tablica = new double[10];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = inputDouble();
            }
            WyswietlOdPierwszego(tablica);
            WyswietlOdOstatniego(tablica);
            WyswietlNieparzyste(tablica);
            WyswietlParzyste(tablica);
        }


        static void SumaElementow(double[] tablica)
        {
            double suma = tablica.Sum();
            Console.WriteLine($"Suma elemntów tablicy wynosi: {suma}.");
        }
        static void IloczynElemenow(double[] tablica)
        {
            double iloczyn = 1;
            for (int i = 0; i < tablica.Length; i++)
            {
                iloczyn *= tablica[i];
            }
            Console.WriteLine($"Iloczyn elementów tablicy wynosi {iloczyn}.");
        }
        static void SredniaElementow(double[] tablica)
        {
            double srednia = tablica.Average();
            Console.WriteLine($"Średnia elementów tablicy wynosi {srednia}.");
        }
        static void WartoscMinimalna(double[] tablica)
        {
            double minimalna = tablica.Min();
            Console.WriteLine($"Minimalna wartość elemtów tablicy wynosi: {minimalna}.");
        }
        static void WartoscMaksymalna(double[] tablica)
        {
            double maksymalna = tablica.Max();
            Console.WriteLine($"Maksymalna wartość elemtów tablicy wynosi: {maksymalna}.");
        }
        static void zad4()
        {
            double[] tablica = new double[10];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = inputDouble();
            }
            SumaElementow(tablica);
            IloczynElemenow(tablica);
            SredniaElementow(tablica);
            WartoscMaksymalna(tablica);
            WartoscMinimalna(tablica);
        }
        static void zad5()
        {
            double[] wylaczone = new double[] { 2, 6, 9, 15, 19 };
            for (int i = 20; i <= 0; i--)
            {
                if (wylaczone.Contains(i))
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        static int inputInt()
        {
            Console.WriteLine("Podaj liczbę całkowitą");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void zad6()
        {
            while (true)
            {
                int liczba = inputInt();
                if (liczba < 0)
                {
                    break;
                }
            }
        }

        static void zad7()
        {
            Console.WriteLine("Podaj ilość liczb które chcesz wprowadzić");
            int n = inputInt();
            double[] tablica = new double[n];
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = Convert.ToDouble(Console.ReadLine());
            }
            BubbleSort(tablica);
            InsertionSort(tablica);
        }

        static void BubbleSort(double[] tablica)
        {
            for (int i = 0; i < tablica.Length - 1; i++)
            {
                for (int j = 1; j < tablica.Length - i; j++)
                {
                    if (tablica[j - 1] > tablica[j])
                    {
                        double temp = tablica[j - 1];
                        tablica[j - 1] = tablica[j];
                        tablica[j] = temp;
                    }
                }
            }
        }
        static void InsertionSort(double[] tablica)
        {
            for (int i = 1; i < tablica.Length; i++)
            {
                double k = tablica[i];
                int j = i - 1;
                while (j >= 0 && tablica[j] > k)
                {
                    tablica[j + 1] = tablica[j];
                    j = j - 1;
                }
                tablica[j + 1] = k;
            }
        }


    }
}