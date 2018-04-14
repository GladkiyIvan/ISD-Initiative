using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._3
{
    class Ship : Vehicle
    {
        public int Passengers { get; set; }
        public string Port { get; set; }
        public Ship(int x, int y, double price, double speed, int year, int passengers, string port) : base(x,y,price, speed, year)
        {
            Passengers = passengers;
            Port = port;
        }
        new public void Out()
        {
            base.Out();
            Console.WriteLine("Пассажиры: "+ Passengers + "\nПорт приписки: " + Port);
        }
    }
}
