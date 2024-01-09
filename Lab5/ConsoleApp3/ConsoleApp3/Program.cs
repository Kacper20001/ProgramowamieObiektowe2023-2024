using System.Diagnostics;

namespace ConsoleApp3
{
    public class SomeClass
    {
        public void CanThrowException(int instructionNumber)
        {
            if (new Random().Next(5) == 0)
                throw new Exception("Wyjątek w instrukcji numer: " + instructionNumber);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SomeClass someClassObj = new SomeClass();
            int instructionNumber = 0;
            try
            {
                someClassObj.CanThrowException(instructionNumber++);
                someClassObj.CanThrowException(instructionNumber++);
                someClassObj.CanThrowException(instructionNumber++);
                someClassObj.CanThrowException(instructionNumber++);
                someClassObj.CanThrowException(instructionNumber++);
            }

            catch (Exception e)
            {
                Console.WriteLine("Wyjątek wystąpił w instrukcji numer: " + instructionNumber);
            }
        }
    }
}

