using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set first number : ");
            if (!int.TryParse(Console.ReadLine(), out int num1))
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            Console.Write("Set second number : ");
            if (!int.TryParse(Console.ReadLine(), out int num2))
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            Console.WriteLine((num1 > num2 ? "First number is bigger : " + num1 : (num1 < num2 ? "Second number is bigger : " + num2 : "They are equal : " + num1)));
            Console.ReadKey();
        }
    }
}
