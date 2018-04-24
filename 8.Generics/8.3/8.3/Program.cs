using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8._3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<char, string> dictionary = new MyDictionary<char, string>();
            dictionary.Add('1', "In");
            dictionary.Add('2', "God");
            dictionary.Add('3', "We");
            dictionary.Add('4', "Trust");

            Console.WriteLine("Overall amount of elements : "+ dictionary.Count);
            Console.Write(dictionary['1'] + " ");
            Console.Write(dictionary['2'] + " ");
            Console.Write(dictionary['3'] + " ");
            Console.Write(dictionary['4'] + " ");
            

            Console.ReadKey();

        }
    }
}
