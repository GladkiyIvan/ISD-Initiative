using System;
using System.Collections;
using System.Collections.Generic;

namespace _9._4
{
    class MyList<T> : IEnumerable<T>
    {
        List<T> myList;

        public int Count
        {
            get
            {
                return myList.Count;
            }
        }

        public MyList()
        {
            myList = new List<T>();
        }

        public T this[int index]
        {
            get
            {
                if (index >= myList.Count) throw new Exception("Индекс за пределами коллекции");
                return myList[index];
            }
        }

        public void Add(T item)
        {
            myList.Add(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)myList).GetEnumerator();
        }
    }
}
