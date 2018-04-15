using System;

namespace _2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer = "Эндрю Троелсен";
            string provider = "издательство 'Стенгазета'";
            string article = "Язык программирования C# 5.0 и платформа .NET 4.5";

            Console.WriteLine("--- заказ на печать статей ---");
            Console.WriteLine($"Заказчик:               {customer}");
            Console.WriteLine($"Поставщик:              {provider}");
            Console.WriteLine($"Название:               {article}");

            int quantity = 0;
            while (true)
            {
                Console.Write("Количество экземпляров: ");
                if (int.TryParse(Console.ReadLine(), out quantity))
                    break;
            }

            Invoice invoice = new Invoice(1, customer, provider, article, quantity);
            
            Console.WriteLine("------------------------------");

            Console.WriteLine($"Цена (без НДС): {invoice.GetCost(false)}");
            while (true)
            {
                Console.Write("\nЖелаете просмотреть цену с НДС? (y/n): ");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    Console.WriteLine($"Цена (с НДС): {invoice.GetCost(true)}");
                    break;
                }
                else if (input == "n")
                {
                    break;
                }
            }

            Console.WriteLine("\nНажмите любую клавишу...");

            Console.ReadKey();
        }
    }
}
