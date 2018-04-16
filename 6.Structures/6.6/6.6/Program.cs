using System;

namespace _6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Норма: ");
            Console.WriteLine(" Junior - 160 часов/месяц");
            Console.WriteLine(" Middle - 150 часов/месяц");
            Console.WriteLine(" Senior - 140 часов/месяц");

            Console.WriteLine("\nПримеры:");
            Console.WriteLine($" Junior - 170 часов/месяц - премия = {Accauntant.AskForBonus(Post.Junior, 170)}");
            Console.WriteLine($" Middle - 150 часов/месяц - премия = {Accauntant.AskForBonus(Post.Middle, 150)}");
            Console.WriteLine($" Senior - 150 часов/месяц - премия = {Accauntant.AskForBonus(Post.Senior, 150)}");

            Console.ReadKey();
        }
    }
}
