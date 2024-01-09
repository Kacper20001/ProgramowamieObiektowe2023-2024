namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = null;
            try
            {
                PrintLength(input);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                //throw ex;
                Exception newException = new Exception("Nie można obliczyć długości napisu o wartości null", ex);
                throw newException;
            }


        }

        static void PrintLength(string input)
        {
            int inputLength = input.Length;
            Console.WriteLine($"Długość to: {inputLength}");
        }
    }
}
