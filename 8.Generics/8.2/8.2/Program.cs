using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("Haldkiy");
            myList.Add("Ivan");
            Console.WriteLine($"Ваш лист: {myList[0]} {myList[1]}");
            Console.WriteLine($"Количество элементов в сипске = {myList.Count}");
            Console.ReadKey();
        }
    }
}
