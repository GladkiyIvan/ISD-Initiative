namespace _2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 4, "C");
            Point D = new Point(0, 4, "D");
            Figure square = new Figure("Квадрат", A, B, C, D);
            square.PerimeterCalculator();
            System.Console.ReadKey();
        }
    }
}
