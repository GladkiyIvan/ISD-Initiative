using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2
{
    class MyList<T>
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
    }
}
