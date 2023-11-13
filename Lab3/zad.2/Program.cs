namespace zad._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SamochodOsobowy samochodOsobowy1 = new SamochodOsobowy();
            samochodOsobowy1.WyswietlInformacjeSamochod();

            Samochod samochod1 = new Samochod();
            samochod1.WyswietlInformacjeSamochod();

            Samochod samochod2 = new Samochod("Ford", "Mondeo", "kombi", "srebrny", 2018, 210000);
            samochod2.WyswietlInformacjeSamochod();
        }
    }
}