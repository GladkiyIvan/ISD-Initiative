using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            double result = 0;
            Console.WriteLine("Введите 5 целых чисел: ");

            Console.CursorTop++;

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Введите число: ");

                    if (!int.TryParse(Console.ReadLine(), out numbers[i]))
                    {
                        Console.WriteLine("Попробуйте еще раз!");
                        continue;
                    }

                    break;
                }

                result += numbers[i];
            }

            result /= 5;

            Console.CursorTop++;

            Console.Write($"Среднее арифметическое ваших чисел = {result}");
            Console.ReadKey();
        }
    }
}
