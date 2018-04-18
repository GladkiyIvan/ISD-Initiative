using System;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 145, -5 };
            arr.Sort(true);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            int[] arr1 = { 19, 37, -3, 3, 91, -322 };
            arr1.Sort(false);
            Console.WriteLine("");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
