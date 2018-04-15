using System;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                ShowUI();
            }
        }

        static void ShowUI()
        {
            Console.WriteLine("Выбор метода: ");
            Console.WriteLine(" 1. MySubstring(int, int)");
            Console.WriteLine(" 2. MyIndexOf(string)");
            Console.WriteLine(" 3. MyReplace(string, string)");
            Console.Write("Ввод: ");
            string input = Console.ReadLine();
            Console.WriteLine("-----------------------------");

            bool canInvoke = true;
            switch (input)
            {
                case "1":
                    Console.WriteLine("Получить новую строку путём извлечения заданного количества символов, начиная с заданного индекса");
                    Console.Write("Строка:              ");
                    string str1 = Console.ReadLine();
                    Console.Write("Индекс:              ");
                    if (!int.TryParse(Console.ReadLine(), out int index))
                        canInvoke = false;
                    Console.Write("Количество символов: ");
                    if (!int.TryParse(Console.ReadLine(), out int count))
                        canInvoke = false;

                    if (canInvoke)
                        Console.WriteLine($"Вывод:               {str1.MySubstring(index, count)}");
                    else
                        Console.WriteLine("Некорректные аргументы");

                    ExitFromCast();
                    break;
                case "2":
                    Console.WriteLine("Получить индекс первого вхождения подстроки в строку");
                    Console.Write("Строка:            ");
                    string str2 = Console.ReadLine();
                    Console.Write("Искомая подстрока: ");
                    string find = Console.ReadLine();
                    Console.WriteLine($"Вывод:             {str2.MyIndexOf(find)}");

                    ExitFromCast();
                    break;
                case "3":
                    Console.WriteLine("Заменить все вхождения подстроки в строке на новую подстроку");
                    Console.Write("Строка:                              ");
                    string str3 = Console.ReadLine();
                    Console.Write("Подстрока, которую следует заменить: ");
                    string oldValue = Console.ReadLine();
                    Console.Write("Подстрока, которую следует вставить: ");
                    string newValue = Console.ReadLine();
                    Console.WriteLine($"Вывод:                               {str3.MyReplace(oldValue, newValue)}");

                    ExitFromCast();
                    break;
            }
        }
        static void ExitFromCast()
        {
            Console.WriteLine("\nНажмите любую кнопку, чтобы продолжить...");
            Console.ReadKey();

            Console.WriteLine("=============================");
        }
    }
}