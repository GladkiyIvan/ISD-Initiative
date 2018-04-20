using System;
using System.Collections.Generic;

namespace _9._1
{
    class Program
    {
        public static IEnumerable<int> PairNumbers(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    yield return array[i];
                }
            }
        }
        static void Main(string[] args)
        {
            int[] array = { 3, 4, 8, 12, 10, 9, 3, 5, 14 };
            IEnumerable<int> pairArray =  PairNumbers(array);
            Console.ReadKey();
        }
    }
}
