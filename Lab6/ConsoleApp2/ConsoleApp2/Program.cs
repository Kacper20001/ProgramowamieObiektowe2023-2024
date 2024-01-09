namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("test2.txt"))
            {
                string content = File.ReadAllText("test2.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
        }
    }
}
