using System;

namespace _8._7
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(4);
            arr.Add(140);
            arr.Add("Hello, world!");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine(arr[i]);
            }
            arr.Remove(4);
            arr.Clear();
            Console.ReadKey();
        }
    }
}
