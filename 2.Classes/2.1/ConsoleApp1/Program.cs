using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Adress my = new Adress();
            Console.Write("Set index: ");
            my.Index = Console.ReadLine();
            Console.Write("Set country: ");
            my.Country = Console.ReadLine();
            Console.Write("Set city: ");
            my.City = Console.ReadLine();
            Console.Write("Set street: ");
            my.Street = Console.ReadLine();
            Console.Write("Set № house: ");
            int house = 0;
            if (!int.TryParse(Console.ReadLine(), out house))
            {
                Console.WriteLine("Wrong input.");
                return;
            }
            int apartment = 0;
            Console.Write("Set Apartment: ");
            if (!int.TryParse(Console.ReadLine(), out apartment))
            {
                Console.WriteLine("Wrong input.");
                return;
            }
            my.House = house;
            my.Apartment = apartment;
            my.output();
                     
            Console.ReadKey();
        }
    }
}
