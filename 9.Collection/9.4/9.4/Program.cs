using System;

namespace _9._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Конвертация типа, реализующего интерфейс IEnumerable<T> в массив T[]\n");

            MyList<int> list = new MyList<int>() { 1, 2, 3 };

            foreach (int i in list.GetArray())
                Console.Write(i + " ");

            Console.ReadKey();
        }
    }
}
