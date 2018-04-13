using System;

namespace _1._2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Randomizator = new Random();
            int sum = 0;
            Console.Write("5 случайных чисел: ");
            for (int i = 0; i < 5; i++)
            {
                int value = Randomizator.Next(100);
                Console.Write(value + " ");
                sum += value;
            }
            Console.WriteLine("\nИх среднее арифметическое число равно " + (sum / 5));
            Console.ReadKey();
        }
    }
}
