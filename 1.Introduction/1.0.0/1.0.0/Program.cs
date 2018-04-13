using System;

namespace _1._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string invitation = "Введите Ф.И.О.: ";
            Console.Write(invitation);
            string user = Console.ReadLine();

            string output = "              +";

            for (int i = 0; i < user.Length + 2; i++)
            {
                output += "-";
            }
            output += "+\n";
            output += "              | " + user + " |\n              +";
            for (int i = 0; i < user.Length + 2; i++)
            {
                output += "-";
            }
            output += "+";
            Console.WriteLine(output);

            Console.CursorVisible = false;

            Console.ReadKey();
        }
    }
}