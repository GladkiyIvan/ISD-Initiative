using System.IO;
using System;

namespace _10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo dirInfo;

            try
            {
                for (int i = 0; i < 100; i++)
                {
                    dirInfo = new DirectoryInfo($@"{appPath}/MyBins/Folder_{i}");
                    dirInfo.Create();
                }

                Console.WriteLine("Ваши папки были созданы в директории: Debug/MyBins/...");
                Console.WriteLine("Нажмите любую клавишу, чтоб удалить эти папки.");

                Console.ReadKey();

                for (int i = 0; i < 100; i++)
                {
                    dirInfo = new DirectoryInfo($@"{appPath}/MyBins/Folder_{i}");
                    dirInfo.Delete();
                }

                Console.WriteLine("Папки были удалены.");

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Что-то пошло не так: {e.ToString()}");
            }
        }
    }
}
