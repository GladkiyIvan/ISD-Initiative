using System;

namespace _8._4
{

    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            int[] arr = myList.GetArray();
            Console.WriteLine("Ваш лист: "  );
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine($"\nКоличество элементов в сипске = {myList.Count}");
            Console.ReadKey();
        }
    }
}
