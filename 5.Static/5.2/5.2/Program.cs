using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;

            while (true)
            {
                Console.Write("Введите размерность массива: ");

                if (!int.TryParse(Console.ReadLine(), out length) || length <= 0)
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз!");
                    continue;
                }
                break;
            }

            int[] arr = new int[length];

            Console.CursorTop++;

            for (int i = 0; i < length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите {i + 1}-й элемент массива: ");

                    if (!int.TryParse(Console.ReadLine(), out arr[i]))
                    {
                        Console.WriteLine("Некорректный ввод. Попробуйте еще раз!");
                        continue;
                    }
                    break;
                }
            }

            Console.CursorTop++;
            arr = arr.QuickSort(0, arr.Length - 1);

            Console.Write("Ваш отсортированный массив: ");

            for (int i = 0; i < length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.ReadKey();
        }
    }
}
