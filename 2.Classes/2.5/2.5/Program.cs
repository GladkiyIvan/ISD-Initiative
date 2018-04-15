using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] date = new int[3];
            Console.Write("Set year: ");
            if (!int.TryParse(Console.ReadLine(), out date[0]) || date[0] < 0 )
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            Console.Write("Set month: ");
            if (!int.TryParse(Console.ReadLine(), out date[1]) || date[1] > 12 || date[1] < 0 )
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            Console.Write("Set day: ");
            if (!int.TryParse(Console.ReadLine(), out date[2]) || date[2] > 31 || date[1] < 0 )
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            User Mark = new User(date[0],date[1],date[2]);
            Console.Write("Set login: ");
            Mark.Login = Console.ReadLine();
            Console.Write("Set name: ");
            Mark.Name = Console.ReadLine();
            Console.Write("Set surname: ");
            Mark.Surname = Console.ReadLine();
            Console.Write("Set age: ");
            Mark.Age = uint.Parse(Console.ReadLine());


            Console.WriteLine("============");
            Console.WriteLine("Your name: " + Mark.Name);
            Console.WriteLine("Your login: " + Mark.Login);
            Console.WriteLine("Your surname: " + Mark.Surname);
            Console.WriteLine("Your age: " + Mark.Age);
            Console.WriteLine("Date: " + Mark.fullDate);
            Console.WriteLine("============");
            Console.ReadKey();
        }
    }
}
