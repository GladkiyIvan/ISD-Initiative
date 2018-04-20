using System;

namespace _8._7
{
    class ArrayList
    {
        public int Count;
        object[] arrayOfObjects;
        public ArrayList()
        {
            arrayOfObjects = new object[0];
            Count = 0;
        }

        public ArrayList(int n)
        {
            arrayOfObjects = new object[n];
            Count = n;
        }

        public bool Contains(object o)
        {
            for (int i = 0; i < arrayOfObjects.Length; i++)
            {
                if (arrayOfObjects[i].Equals(o))
                {
                    return true;
                }
            }
            return false;
        }

        public int IndexOf(Object o)
        {
            if (Count != 0)
            {
                int index = 0;
                for (int i = 0; i < arrayOfObjects.Length; i++)
                {
                    if (arrayOfObjects[i].Equals(o))
                    {
                        return index;
                    }
                    index++;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index < Count)
            {
                object[] newArray = new object[Count - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = arrayOfObjects[i];
                }
                for (int i = index; i < newArray.Length; i++)
                {
                    newArray[i] = arrayOfObjects[i + 1];
                }
                Count--;
                arrayOfObjects = newArray;
            }
        }

        public void Remove(object o)
        {
            if (Count != 0)
            {
                for (int i = 0; i < arrayOfObjects.Length; i++)
                {
                    if (arrayOfObjects[i].Equals(o))
                    {
                        object[] newArray = new object[Count - 1];
                        int index = IndexOf(o);
                        for (int j = 0; j < index; j++)
                        {
                            newArray[j] = arrayOfObjects[j]; 
                        }
                        for (int j = index; j < newArray.Length; j++)
                        {
                            newArray[j] = arrayOfObjects[j + 1];
                        }
                        arrayOfObjects = newArray;
                        Count--;
                        return;
                    }
                }
            }
        }

        public void Add(object o)
        {
            object[] newArray = new object[arrayOfObjects.Length + 1];
            arrayOfObjects.CopyTo(newArray, 0);
            newArray[arrayOfObjects.Length] = o;
            arrayOfObjects = newArray;
            Count++;
        }

        public void Clear()
        {
            arrayOfObjects = new object[0];
            Count = 0;
        }

        public object this[int number]
        {
            get { return arrayOfObjects[number]; }
            set { arrayOfObjects[number] = value; }
        }
    }
}
