using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(3, 4, 10000, 250, 1944);
            car.Out();
            Plane plane = new Plane(14, 20, 5000, 1490000, 800, 2001, 89);
            plane.Out();
            Ship ship = new Ship(-42, 23, 1590000, 45, 1911, 1500, "Нью-Йорк");
            ship.Out();
            Console.ReadKey();
        }
    }
}
