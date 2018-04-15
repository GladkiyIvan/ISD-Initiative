using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class PrinterYellow : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ваша жёлтая строка: ");
            Console.WriteLine(value);
            Console.CursorTop++;
        }
    }
}
