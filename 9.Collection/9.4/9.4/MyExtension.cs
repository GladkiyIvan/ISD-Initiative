using System.Collections.Generic;

namespace _9._4
{
    static class MyExtension
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            List<T> newList = new List<T>();
            foreach (T item in list)
                newList.Add(item);

            T[] array = new T[newList.Count];

            for(int i = 0; i < array.Length; i++)
                array[i] = newList[i];

            return array;
        }
    }
}
