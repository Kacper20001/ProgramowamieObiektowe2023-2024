namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program pozwalający na zapisanie do pliku o wskazanej nazwie, nr albumu osoby, któranapisała program.

            Console.WriteLine("Please enter new content for the \"test\" file");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);

        }
    }
}
