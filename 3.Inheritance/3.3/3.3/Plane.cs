using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Plane : Vehicle
    {
        public int Z { get; set; }
        public int Passengers { get; set; }
        public Plane(int x, int y, int z, double price, double speed, int year, int passengers) : base(x, y, price, speed, year)
        {
            Z = z;
            Passengers = passengers;
        }
        new public void Out()
        {
            base.Out();
            Console.WriteLine("Высота: " + Z + "\nПассажиры: " + Passengers);
        }
    }
}
