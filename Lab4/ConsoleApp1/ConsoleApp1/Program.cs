namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        List<Shape> shapes = new List<Shape> {new Rectangle(), new Triangle(), new Circle()};
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
