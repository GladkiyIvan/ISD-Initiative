using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            while (true)
            {
                Console.Write("Введите число: ");

                if(!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    continue;
                }

                if(number < 2)
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    continue;
                }

                break;
            }

            Console.CursorTop++;

            for (int i = number - 1; i > 0; i--)
            {
                int temp = i * i;
                Console.WriteLine($"Квадрат числа {i} = {temp}");
            }

            Console.ReadKey();
        }
    }
}
