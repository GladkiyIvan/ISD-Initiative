using System;

namespace _1._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            if(!int.TryParse(Console.ReadLine(), out int value))
            {
                Console.WriteLine("Wrong input.");
                Console.ReadKey();
                return;
            }
            int counter = 0;
            while (value != 0)
            {
                value /= 10;
                counter++;
            }
            Console.WriteLine("The digit has: " + counter + " numbers ");
            Console.ReadKey();
        }
    }
}
