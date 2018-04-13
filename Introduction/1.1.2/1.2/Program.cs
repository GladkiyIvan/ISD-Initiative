using System;

namespace _1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set sound of an animal: ");
            string str = Console.ReadLine();
            if (str == "mew")
            {
                Console.WriteLine("Feed the cat !");
            }
            else if (str == "woof")
            {
                Console.WriteLine("Feed the dog !");
            }
            else
            {
                Console.WriteLine("Wrong input .");
            }
            Console.ReadKey();
        }
    }
}
