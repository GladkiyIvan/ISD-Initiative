using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        double Price { get; set; }
        double Speed { get; set; }
        int Year { get; set; }

        public Vehicle(int x, int y, double price, double speed, int year)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            Year = year;
        }
        public void Out()
        {
            Console.WriteLine("Координаты: " + X + " " + Y + "\nЦена: " + Price + "\nСкорость: " + Speed + "\nГод: " + Year);
        }
    }
}
