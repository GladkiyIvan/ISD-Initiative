using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2._7
{
    class Program
    {
        static void CalculateCombinations(int totalLegs, int rabbits, int geese)
        {
            while (totalLegs >= 0)
            {
                int tmp = totalLegs;
                while (totalLegs > 0)
                {
                    totalLegs -= 2;
                    geese++;
                }
                if (totalLegs == 0)
                {
                    Console.WriteLine("Кролики: " + rabbits);
                    Console.WriteLine("Гуси: " + geese);
                    Console.WriteLine("------------");
                }
                totalLegs = tmp - 4;
                rabbits++;
                geese = 0;
            }
        }

        static void Main(string[] args)
        {
            int totalLegs = 64;
            int rabbits = 0;
            int geese = 0;
            CalculateCombinations(totalLegs, rabbits, geese);
            Console.ReadKey();
        }
    }
}