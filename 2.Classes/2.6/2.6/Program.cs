using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter Converter = new Converter(26.71, 32.92, 0.4304);
            Console.WriteLine("100 гривен это: " + Converter.ConvertToUSD(100) + 
                                   " долларов, " + Converter.ConvertToEUR(100) + 
                                   " евро, " + Converter.ConvertToRUB(100) +" рублей");
            Console.WriteLine("100 долларов - " + Converter.ConvertFromUSD(100) + " гривен");
            Console.WriteLine("100 евро - " + Converter.ConvertFromEUR(100) + " гривен");
            Console.WriteLine("100 рублей - " + Converter.ConvertFromRUB(100) + " гривен");
            Console.ReadKey();
        }
    }
}
