using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1
{
    struct Notebook
    {
        string model;
        string manufacturer;
        int price; 

        public Notebook (string model, string manufacturer, int price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        public void Print()
        {
            Console.WriteLine("Ваш ноутбук:");
            Console.WriteLine($"Модель: {model}, Производитель: {manufacturer}, Цена: {price}");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите название модели: ");
            string model = Console.ReadLine();
            Console.Write("Введите название производителя: ");
            string manufacturer = Console.ReadLine();
            int price;
            while (true)
            {
                Console.Write("Введите цену: ");

                if(!int.TryParse(Console.ReadLine(), out price) || price <= 0)
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз!");
                    continue;
                }
                break;
            }

            Console.CursorTop++;

            Notebook notebook = new Notebook(model, manufacturer, price);
            notebook.Print();
        }
    }
}
