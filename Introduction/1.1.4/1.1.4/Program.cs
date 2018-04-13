using System;

namespace _1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                Console.Write("Введите 1 или 0: ");

                if (!int.TryParse(Console.ReadLine(), out number) )
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    continue;
                }

                if(number !=0 && number != 1)
                {
                    Console.WriteLine("Попробуйте еще раз!");
                    continue;
                }
                break;
            }

            Console.WriteLine(number == 0 ? "Плохо" : "Хорошо");
            Console.ReadKey();
        }
    }
}
