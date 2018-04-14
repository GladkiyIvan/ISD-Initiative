using System;

namespace _3._4
{
    class Program
    {
        static string proKey = "abc";
        static string expKey = "cba";

        static DocumentWorker documentWorker;

        static void Main(string[] args)
        {
            ShowUI();

            ShowAvailableMethods();

            Console.WriteLine("Нажмите, чтобы продолжить...");
            Console.ReadKey();
        }

        static void ShowUI()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Добро пожаловать в DocumentWorker(c)!");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("Меню: ");
                Console.WriteLine(" 1. Использовать бесплатную версию");
                Console.WriteLine(" 2. Ввести ключ продукта");
                Console.Write("Ввод: ");

                if (int.TryParse(Console.ReadLine(), out int select))
                {
                    if (select == 1)
                    {
                        documentWorker = new DocumentWorker();
                        Console.Clear();
                        Console.WriteLine("Выбрана бесплатная версия!");
                        Console.WriteLine("--------------------------");
                        break;
                    }
                    else if (select == 2)
                    {
                        InputKey();
                        break;
                    }
                }
            }
        }

        static void InputKey()
        {
            Console.Clear();

            Console.Write("Введите ключ: ");
            string input = Console.ReadLine();

            Console.Clear();

            if (input == proKey)
            {
                documentWorker = new ProDocumentWorker();
                Console.WriteLine("Pro-версия успешно активирована!");
                Console.WriteLine("--------------------------------");
                
            }
            else if (input == expKey)
            {
                documentWorker = new ExpertDocumentWorker();
                Console.WriteLine("Expert-версия успешно активирована!");
                Console.WriteLine("-----------------------------------");
            }
            else
            {
                Console.WriteLine("Ключ введён неверно!");
                Console.WriteLine("--------------------");
                Console.WriteLine("Нажмите, чтобы продолжить...");
                Console.ReadKey();
                ShowUI();
            }
        }

        static void ShowAvailableMethods()
        {
            Console.WriteLine("\n=== Доступные методы ===\n");

            Console.WriteLine("OpenDocument()");
            documentWorker.OpenDocument();
            Console.WriteLine("---");

            Console.WriteLine("EditDocument()");
            documentWorker.EditDocument();
            Console.WriteLine("---");

            Console.WriteLine("SaveDocument()");
            documentWorker.SaveDocument();
            Console.WriteLine("---");
        }
    }
}
