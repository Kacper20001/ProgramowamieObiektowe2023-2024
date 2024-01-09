namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                ThrowRadomlyException();
            }
            catch (Exception1 ex)
            {
                Console.WriteLine("Złapano wyjatek:" + ex);
            }
            catch (Exception2 ex) 
            {
                Console.WriteLine("Złapano wyjątek:" + ex);
            }
            catch(Exception3 ex) 
            {
                Console.WriteLine("Złapano wyjątek:" + ex);
            }
        }

        class Exception1 : Exception 
        {
            public Exception1(string message) : base(message) { } 
        }
        class Exception2 : Exception
        {
            public Exception2 (string message) : base(message) { }
        }
        class Exception3 : Exception
        {
            public Exception3 (string message) : base(message) { }
        }

        static void ThrowRadomlyException()
        {
            Random random = new Random(); ;
            int randomNumber = random.Next(1, 4);

            switch (randomNumber)
            {
                case 1:
                    throw new Exception1("Wyjątek numer 1");
                case 2:
                    throw new Exception2("Wyjątek numer 2");
                case 3:
                    throw new Exception3("Wyjątek numer 3");
            }
        }
    }
}
