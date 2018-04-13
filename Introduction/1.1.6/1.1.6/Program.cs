using System;

namespace _1._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int amountOfKilometers;
            int wastedMinutes;
            string checkString;
            do
            {
                do
                {
                    Console.Write("Введите количество километров: ");
                    checkString = Console.ReadLine();
                } while (!Int32.TryParse(checkString, out amountOfKilometers));
                do
                {
                    Console.Write("Введите количество минут простоя: ");
                    checkString = Console.ReadLine();
                } while (!Int32.TryParse(checkString, out wastedMinutes));
            } while (amountOfKilometers < 0 || wastedMinutes < 0);
            int Payment = 20;
            if (amountOfKilometers > 5)
            {
                Payment += (amountOfKilometers - 5) * 3;
            }
            Payment += wastedMinutes;
            Console.WriteLine("К оплате " + Payment + " гривен");
            Console.ReadKey();
        }
    }
}
