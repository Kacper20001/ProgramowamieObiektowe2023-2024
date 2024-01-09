namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> hobbyList = new List<string> { "Piłka nożna", "Siatkówka" };
            Osoba osoba1 = new Osoba("Kacper", "Kulig", 22, hobbyList);

            if (osoba1 == null) 
            {
                throw new Exception("Nie można sklonoować obiektu, który jest null");
            }
            
            Osoba osoba2 = (Osoba)osoba1.Clone();
            osoba2.firstName = "Szymon";
            osoba2.wiek = 14;
            osoba2.hobby.Add("Nurkowanie");

            Console.WriteLine($"Osoba1: Imię: {osoba1.firstName}, wiek: {osoba1.wiek}, lista hobby: {String.Join(", ", osoba1.hobby)}");
            Console.WriteLine($"Osoba2: Imię: {osoba2.firstName}, wiek: {osoba2.wiek}, lista hobby: {String.Join(", ", osoba2.hobby)}");
        }
    }
}
