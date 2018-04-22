using System;
using System.IO;
using System.IO.Compression;
using System.Text;

namespace _10._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowUI();      
        }

        static void ShowUI()
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
                
                if(text.Length > 0)
                {
                    Console.WriteLine("\n----------");
                    Console.WriteLine(text);
                    Console.WriteLine("----------");

                    ShowCompressionUI(path);
                }

                Console.WriteLine("\nНажмите, чтобы продолжить...");
                Console.ReadKey();
            } 
        }
        static void ShowCompressionUI(string path)
        {
            Console.Write("\nВыполнить сжатие файла? (y/n): ");
            if (Console.ReadLine() == "y")
            {
                Console.Write("Новое имя сжатого файла      : ");
                string compressedPath = Console.ReadLine();
                Compression(path, compressedPath);
                
                Console.Write("\nВыполнить декомпрессию? (y/n)       : ");
                if (Console.ReadLine() == "y")
                {
                    Console.Write("Новое имя декомпрессированного файла: ");
                    string decompressedPath = Console.ReadLine();
                    Decompression(compressedPath, decompressedPath);

                    if (CheckDecompression(path, decompressedPath))
                        Console.WriteLine("\nДекомпрессия выполнена успешно");
                    else
                        Console.WriteLine("\nОшибка декомпрессии");
                }
            }
            Console.WriteLine("\nНажмите, чтобы продолжить...");
            Console.ReadLine();
            ShowUI();
        }
        static void Compression(string path, string compressedPath)
        {
            try
            {
                using (FileStream readStream = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream writeStream = File.Create(compressedPath))
                    {
                        using (GZipStream compressionStream = new GZipStream(writeStream, CompressionMode.Compress))
                        {
                            readStream.CopyTo(compressionStream);

                            Console.WriteLine($"\nСжатие файла {path} завершено \nИсходный размер: {readStream.Length} байт \nCжатый размер:   {writeStream.Length} байт");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nОшибка: " + e.Message);
            }
        }
        static void Decompression(string compressedFile, string decompressedFile)
        {
            try
            {
                using (FileStream readStream = new FileStream(compressedFile, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream writeStream = File.Create(decompressedFile))
                    {
                        using (GZipStream decompressionStream = new GZipStream(readStream, CompressionMode.Decompress))
                        {
                            decompressionStream.CopyTo(writeStream);

                            Console.WriteLine($"\nФайл {compressedFile} восстановлен");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\nОшибка: " + e.Message);
            }
        }
        static bool CheckDecompression(string sourcePath, string decompressedPath)
        {
            return File.ReadAllText(sourcePath) == File.ReadAllText(decompressedPath) ? true : false;
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