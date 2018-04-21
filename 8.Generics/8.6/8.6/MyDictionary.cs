using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._6
{
    class MyDictionary<TKey, TValue> : IEnumerable
    {
        List<TKey> keys;
        List<TValue> values;

        public int Count { get => keys.Count; }

        public MyDictionary()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (!keys.Contains(key))
            {
                keys.Add(key);
                values.Add(value);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        public void Remove(TKey key)
        {
            if (keys.Contains(key))
            {
                int index = keys.IndexOf(key);
                keys.RemoveAt(index);
                values.RemoveAt(index);
            }
            else
            {
                throw new KeyNotFoundException();
            }
        }
        public void RemoveAll()
        {
            keys = new List<TKey>();
            values = new List<TValue>();
        }
        public bool ContainsKey(TKey key)
        {
            return keys.Contains(key);
        }
        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < keys.Count; i++)
                result += keys[i] + " - " + values[i] + "\n";
            return result;
        }
        public IEnumerator GetEnumerator()
        {
            foreach (TValue value in values)
                yield return value;
        }
        public TValue this[TKey key]
        {
            get
            {
                if(keys.Contains(key))
                    return values[keys.IndexOf(key)];

                throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (keys.Contains(key))
                {
                    int index = keys.IndexOf(key);
                    values[index] = value;
                }
                else
                {
                    keys.Add(key);
                    values.Add(value);
                }
            }
        }
    }
}
