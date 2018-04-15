using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printerWhite = new Printer();
            printerWhite.Print("Hello World!");

            printerWhite = new PrinterRed();
            PrinterRed printerRed = printerWhite as PrinterRed;
            if (printerRed != null)
            {
                printerRed.Print("Hello World!");
            }

            printerWhite = new PrinterYellow();
            PrinterYellow printerYellow = printerWhite as PrinterYellow;
            if (printerYellow != null)
            {
                printerYellow.Print("Hello World!");
            }

            printerWhite = new PrinterGreen();
            PrinterGreen printerGreen = printerWhite as PrinterGreen;
            if (printerGreen != null)
            {
                printerGreen.Print("Hello World!");
            }

            Console.ReadKey();
        }
    }
}
