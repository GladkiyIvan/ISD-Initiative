using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double side1;
            double side2;

            while (true)
            {
                Console.Write("Введите длину первой стороны прямоугольника: ");

                if (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз!");
                    continue;
                }
                break;
            }

            Console.CursorTop++;

            while (true)
            {
                Console.Write("Введите длину второй стороны прямоугольника: ");

                if (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
                {
                    Console.WriteLine("Некорректный ввод, попробуйте еще раз!");
                    continue;
                }
                break;
            }


            Rectangle rectangle = new Rectangle(side1, side2);

            Console.CursorTop++;

            Console.WriteLine($"Площадь вашего прямоугольника = {rectangle.Area}, а периметр = {rectangle.Perimeter}.");
            Console.ReadKey();

        }
    }
}
