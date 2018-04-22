using System;
using System.IO;
using System.Text;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string path = "";
                string text = "";

                Console.Clear();
                Console.WriteLine("--- Чтение текстового файла ---\n");

                Console.WriteLine("Меню:");
                Console.WriteLine(" 1. Считать из example.txt");
                Console.WriteLine(" 2. Ввести путь вручную");
                Console.Write("Ввод: ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int select) || input.Length != 1)
                    continue;
                    
                if (select == 1)
                {
                    path = "example.txt";
                }
                else if (select == 2)
                {
                    Console.Write("Путь к файлу: ");
                    path = Console.ReadLine();
                }

                text = GetTextFromFile(path);
                                
                Console.WriteLine("\nНажмите, чтобы продолжить...");
                Console.ReadKey();
            }       
        }

        static string GetTextFromFile(string path)
        {
            string text = "";

            try
            {
                using (FileStream fileStream = File.OpenRead(path))
                {
                    byte[] array = new byte[fileStream.Length];

                    fileStream.Read(array, 0, array.Length);

                    text = Encoding.Default.GetString(array);

                    Console.WriteLine("\n----------");
                    Console.WriteLine(text);
                    Console.WriteLine("----------");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nОшибка: " + e.Message);
            }

            return text;
        }
    }
}
