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
            Console.Write("Set first number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Set second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bigger value is : " + (num1 > num2 ? num1 : num2)) ;
            Console.ReadKey();
        }
    }
}
