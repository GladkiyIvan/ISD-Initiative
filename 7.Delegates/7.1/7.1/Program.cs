using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._1
{
    class Program
    {
        public delegate int FindAverage(int a, int b, int c);

        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            string check;
            do
            {
                Console.Write("Введите а: ");
                check = Console.ReadLine();

            } while (!Int32.TryParse(check, out a));
            do
            {
                Console.Write("Введите b: ");
                check = Console.ReadLine();

            } while (!Int32.TryParse(check, out b));
            do
            {
                Console.Write("Введите c: ");
                check = Console.ReadLine();

            } while (!Int32.TryParse(check, out c));
            FindAverage function = delegate (int val1, int val2, int val3) 
            {
                return (val1 + val2 + val3) / 3;
            };
            Console.WriteLine("Их среднее арифметическое число равно " + function(a, b, c));
            Console.ReadKey();
        }
    }
}
