using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set value: ");

            if (!int.TryParse(Console.ReadLine(), out int n))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Table N * ( 1 - 20 )");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(n + " * " + (i+1) + " = " + n*(i+1) );
            }
            Console.ReadKey();
        }
    }
}
