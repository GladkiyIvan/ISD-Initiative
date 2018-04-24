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
                tKey.Add(key);
                tValue.Add(value);
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
}
