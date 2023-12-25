using GeometryLib.Entities;

namespace GeometryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Line2D line = new Line2D();
            line.StartPoint = new Point2D(12.234f, 14453.3456f);
            line.EndPoint = new Point2D(34.3462f, 2345436.34523f);
            Console.WriteLine(line.GetLength());
        }
    }
}