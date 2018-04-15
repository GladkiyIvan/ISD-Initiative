using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class PrinterRed: Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Ваша красная строка : ");
            Console.WriteLine(value);
            Console.CursorTop++;
        }
    }
}
