using System;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set number of the months : ");
            int.TryParse(Console.ReadLine(), out int month);

            switch (month)
            {
                case 1:
                case 2:
                case 12: 
                    Console.WriteLine("It's Winter !");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's Spring !");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It's Summer !");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It's Autumn !");
                    break;
                default:
                    Console.WriteLine("Wrong Input !");
                    break;
            }
            Console.ReadKey();
        }
    }
}
