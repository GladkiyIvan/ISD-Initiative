using System;
using System.Collections.Generic;

namespace _2._4
{
    class Figure
    {
        public List<Point> points { get; }
        public string Name { get; }
        public Figure(string name, Point a, Point b, Point c)
        {
            Name = name;
            points = new List<Point>();
            points.Add(a);
            points.Add(b);
            points.Add(c);
        }

        public Figure(string name, Point a, Point b, Point c, Point d) : this(name,a,b,c)
        {
            points.Add(d);
        }

        public Figure(string name, Point a, Point b, Point c , Point d, Point e): this(name,a,b,c,d)
        {
            points.Add(e);
        }

        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public void ShowName()
        {
            Console.WriteLine(Name);
        }

        public void PerimeterCalculator()
        {
            double Perimeter = 0;
            for (int i = 0; i < points.Count - 1; i++)
            {
                Perimeter += LengthSide(points[i], points[i + 1]);
            }
            Perimeter += LengthSide(points[points.Count - 1], points[0]);
            Console.WriteLine("Периметр: " + Perimeter);
        }
    }
}
