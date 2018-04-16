using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._5
{
    static class StringColor
    {
        public static void Print(this string str, int color)
        {
            Console.CursorTop++;
            Console.WriteLine("Ваша строка: ");

            switch (color)
            {
                case (int)Color.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(str);
                    break;
                case (int)Color.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(str);
                    break;
                case (int)Color.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(str);
                    break;
                case (int)Color.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(str);
                    break;
            }

            Console.ReadLine();
        }
    }
}
