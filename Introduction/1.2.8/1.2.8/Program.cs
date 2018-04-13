using System;

namespace _1._2._8
{
    class Program
    {
        const string password = "root";

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите пароль: ");

                if (Console.ReadLine() == password)
                {
                    Console.WriteLine("Пароль введён верно!");
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный пароль!");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            Console.ReadKey();
        }
    }
}
