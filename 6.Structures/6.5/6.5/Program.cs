using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    enum Color
    {
        Green = 1,
        Cyan,
        Red,
        Magenta
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string myStr = Console.ReadLine();
            int color;

            while (true)
            {
                Console.Write("Введите номер цвета (Доступный диапазон: 1-зелёный, 2-голубой, 3-красный, 4-фиолетовый): ");

                if (!int.TryParse(Console.ReadLine(), out color) || (color > 4 || color < 1))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз!");
                    continue;
                }

                break;
            }

            myStr.Print(color);
        }
    }
}
