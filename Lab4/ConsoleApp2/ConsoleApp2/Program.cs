namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Monika", "Bieniek", "14230124968", "WSIiZ", true);
            Student student2 = new Student("Katarzyna", "Ziaja", "14250124968", "WSIiZ", false);
            Student student3 = new Student("Jan", "Kowalski", "01270243498", "WSIiZ", false);

            Teacher teacher1 = new Teacher("Zbigniew", "Tarała", "55020894856", "WSIiZ", true, "dr. inż.");
            teacher1.AddStudent(student1);
            teacher1.AddStudent(student2);
            teacher1.AddStudent(student3);

            Console.WriteLine("Studenci sprawdzenie");
            Console.WriteLine(student1.GetGender());
            Console.WriteLine(student2.CanGoAloneToHome());
            Console.WriteLine(student2.GetEducationInfo());
            Console.WriteLine(student3.CanGoAloneToHome());
            Console.WriteLine(student3.GetFullName());


            Console.WriteLine("Profesor sprawdzenie");
            teacher1.WhichStudentCanGoHome(DateTime.Now);
            




        }
    }
}
