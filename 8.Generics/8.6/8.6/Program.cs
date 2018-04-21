using System;

namespace _8._6
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowUI(new MyDictionary<int, string>());
            
            Console.ReadKey();
        }

        static void ShowUI(MyDictionary<int, string> dictionary)
        {
            Console.Clear();

            Console.WriteLine("Работа с классом MyDictionary<TKey, TValue>");
            Console.WriteLine("-------------------------------------------\n");

            if(dictionary.Count != 0)
            {
                Console.WriteLine(dictionary);
                Console.WriteLine($"Количество записей в словаре: {dictionary.Count}");
            }
            else
            {
                Console.WriteLine("Словарь пуст");
            }

            Console.WriteLine("\nМеню:");
            Console.WriteLine(" 1. Добавить пару ключ-значение");
            Console.WriteLine(" 2. Удалить пару ключ-значение");
            Console.WriteLine(" 3. Перезаписать значение");
            Console.WriteLine(" 4. Очистить словарь");
            Console.Write("Ввод: ");
            
            if (!int.TryParse(Console.ReadLine(), out int select))
                ShowUI(dictionary);
            if (select == 1)
                ShowAddUI(dictionary);
            else if (select == 2)
                ShowRemoveUI(dictionary);
            else if (select == 3)
                ShowReplaceUI(dictionary);
            else if (select == 4)
                ShowRemoveAllUI(dictionary);
            else
                ShowUI(dictionary);            
        }
        static void ShowAddUI(MyDictionary<int, string> dictionary)
        {
            Console.Clear();
            Console.WriteLine("Добавление пары ключ-значение");
            Console.WriteLine("------------------------------\n");

            Console.Write("Ключ (int)       : ");
            if (!int.TryParse(Console.ReadLine(), out int key))
                ShowAddUI(dictionary);
            
            Console.Write("Значение (string): ");
            string value = Console.ReadLine();

            try
            {
                dictionary.Add(key, value);
            }
            catch
            {
                Console.WriteLine("\nТакой ключ уже добавлен");
            }

            PressToContinue(dictionary);
        }
        static void ShowRemoveUI(MyDictionary<int, string> dictionary)
        {
            Console.Clear();
            Console.WriteLine("Удаление пары ключ-значение");
            Console.WriteLine("---------------------------\n");

            Console.Write("Ключ: ");
            if (!int.TryParse(Console.ReadLine(), out int key))
                ShowRemoveUI(dictionary);

            if (dictionary.ContainsKey(key))
            {
                var removedKey = key;
                var removedValue = dictionary[key];
                dictionary.Remove(key);
                Console.WriteLine($"\nПара {removedKey} - {removedValue} успешно удалена!");
            }
            else
            {
                Console.WriteLine("\nСловарь не содержит такого ключа");
            }

            PressToContinue(dictionary);
        }
        static void ShowReplaceUI(MyDictionary<int, string> dictionary)
        {
            Console.Clear();
            Console.WriteLine("Перезаписать значение");
            Console.WriteLine("---------------------\n");

            Console.Write("Ключ          : ");
            if (!int.TryParse(Console.ReadLine(), out int key))
                ShowRemoveUI(dictionary);
            Console.Write("Новое значение: ");
            string newValue = Console.ReadLine();

            if (dictionary.ContainsKey(key))
            {
                var removedValue = dictionary[key];

                dictionary[key] = newValue;

                Console.WriteLine($"\nЗначение {removedValue} по ключу {key} успешно изменено на {newValue}!");
            }
            else
            {
                Console.WriteLine("\nСловарь не содержит такого ключа");
            }

            PressToContinue(dictionary);
        }
        static void ShowRemoveAllUI(MyDictionary<int, string> dictionary)
        {
            dictionary.RemoveAll();
            Console.Clear();
            Console.WriteLine("Словарь успешно очищен");
            PressToContinue(dictionary);
        }
        static void PressToContinue(MyDictionary<int, string> dictionary)
        {
            Console.WriteLine("\nНажмите, чтобы продолжить...");
            Console.ReadKey();
            ShowUI(dictionary);
        }
    }
}