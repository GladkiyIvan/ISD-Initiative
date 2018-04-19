using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set 2 numbers : ");
            if (!double.TryParse(Console.ReadLine(), out double x))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                return;
            }
            if (!double.TryParse(Console.ReadLine(), out double y))
            {
                Console.WriteLine("Wrong input");
                Console.ReadKey();
                return;
            }
            Console.WriteLine(x + " + " + y + " = " + Calculator.Add(x, y));
            Console.WriteLine(x + " - " + y + " = " + Calculator.Derogation(x, y));
            Console.WriteLine(x + " * " + y + " = " + Calculator.Multiplication(x, y));
            Console.WriteLine(x + " / " + y + " = " + Calculator.Division(x, y));
            Console.WriteLine(x + " ^ " + y + " = " + Calculator.Power(x, y));
            
            Console.ReadKey();
        }
    }
}
