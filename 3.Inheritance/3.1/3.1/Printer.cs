using System;
namespace _3._1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Ваша строка: ");
            Console.WriteLine(value);
            Console.CursorTop++;
        }
    }
}
