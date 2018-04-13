using System;

namespace _1._1._7
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number > 10)
            {
                for (int i = 3; i < 10; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 3; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int number;
            string stringCheck;
            do
            {
                do
                {
                    Console.Write("Введите число: ");
                    stringCheck = Console.ReadLine();
                } while (!Int32.TryParse(stringCheck, out number));
            } while (number <= 0);
            if (IsPrime(number))
            {
                Console.WriteLine("Простое число");
            }
            else
            {
                Console.WriteLine("Не простое число");
            }
            Console.ReadKey();
        }
    }
}
