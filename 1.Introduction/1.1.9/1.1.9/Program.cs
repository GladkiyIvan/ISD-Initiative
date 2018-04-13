using System;

namespace _1._1._9
{
    class Program
    {
        static int uahForUsd = 26;
        static int uahForEur = 32;

        static double uah;
        static double usd;
        static double eur;

        static void Main(string[] args)
        {
            ShowUI();
            Input();            
            
            Console.ReadKey();
        }
        static void Input()
        {
            Console.Write("\nВведите валюту для обмена\n" +
                          "(формат: <количество> <валюта> (usd/eur/uah)): ");
            string[] input = Console.ReadLine().Split(' ');

            if (input.Length > 2)
                ShowError();

            if (int.TryParse(input[0], out int amount))
            {
                ConvertCurrencies(amount, input[1]);
            }
            else
            {
                ShowError();
            }
        }
        static void ConvertCurrencies(int amount, string currency)
        {
            if (currency == "usd")
            {
                usd = amount;
                uah = usd * uahForUsd;
                eur = uah / uahForEur;
            }
            else if (currency == "eur")
            {
                eur = amount;
                uah = eur * uahForEur;
                usd = uah / uahForUsd;
            }
            else if (currency == "uah")
            {
                uah = amount;
                usd = uah / uahForUsd;
                eur = uah / uahForEur;
            }
            else
            {
                ShowError();
                return;
            }

            Console.WriteLine("--------------------\n");
            Console.WriteLine($"usd: {usd}");
            Console.WriteLine($"eur: {eur}");
            Console.WriteLine($"uah: {uah}");
        }
        static void ShowUI()
        {
            Console.WriteLine("Текущий курс валют:");
            Console.WriteLine($" 1 usd = {uahForUsd} uah");
            Console.WriteLine($" 1 eur = {uahForEur} uah");
            Console.WriteLine("--------------------");
        }
        static void ShowError()
        {
            Console.Clear();
            Console.WriteLine("xxxxxxxxxxxx");
            Console.WriteLine("Ошибка ввода");
            Console.WriteLine("xxxxxxxxxxxx");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            ShowUI();
            Input();
        }
    }
}
