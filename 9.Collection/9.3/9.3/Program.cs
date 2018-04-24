using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> words = new MyDictionary<int, string>();
            words.Add(1, "Like a moth to a flame");
            words.Add(2, "that neon light must've been calling our names");
            words.Add(2, "Cause here we are drinking down doubles");
            words.Add(4, "Drowning out the same kinda troubles that brought us here");
            
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
        }
    }
}
