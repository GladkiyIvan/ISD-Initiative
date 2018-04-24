using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._3
{
    class MyDictionary<TKey, TValue>
    {
        List<TKey> tKey;
        List<TValue> tValue;

        public int Count
        {
            get => tKey.Count;
        }
        public MyDictionary()
        {
            tKey = new List<TKey>();
            tValue = new List<TValue>();
        }
        public void Add(TKey key, TValue value)
        {
            if (key is TKey && value is TValue)
            {
                tKey.Add(key);
                tValue.Add(value);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public TValue this[TKey key]
        {
            get
            {
                if (tKey.Contains(key))
                    return tValue[tKey.IndexOf(key)];

                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (tKey.Contains(key))
                {
                    int index = tKey.IndexOf(key);
                    tValue[index] = value;
                }
                else
                {
                    tKey.Add(key);
                    tValue.Add(value);
                }
            }
        }
        public IEnumerator<TValue> GetEnumerator()
        {
            return tValue.GetEnumerator();
        }
    }
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
