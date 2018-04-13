using System;

namespace _1._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 146);
            int uValue = 0 ;
            Console.WriteLine("Guess the number !"); 
            do
            {
                if(!int.TryParse(Console.ReadLine() , out uValue))
                {
                    Console.WriteLine("Wrong input.");
                    continue;
                }
                Console.WriteLine(value > uValue ? "Try to pick bigger" : value < uValue ? "Try to pick smaller ": "That's it !");
            } while (uValue != value);
            Console.ReadKey();
        }
    }
}
