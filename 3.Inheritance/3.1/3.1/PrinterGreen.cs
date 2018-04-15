using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class PrinterGreen : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Ваша зелёная строка: ");
            Console.WriteLine(value);
            Console.CursorTop++;
        }
    }
}
