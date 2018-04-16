using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2
{
    public static class IntArrExtension
    {
        public static int[] QuickSort(this int[] arr, int firstIndex , int lastIndex )
        {
            int first = firstIndex;
            int last = lastIndex;
            int piv = arr[(firstIndex + lastIndex) / 2];

            while (first <= last)
            {
                while (arr[first] > piv)
                {
                    first++;
                }
                while (arr[last] < piv)
                {
                    last--;
                }
                if (first <= last)
                {
                    int tmp = arr[first];
                    arr[first] = arr[last];
                    arr[last] = tmp;

                    first++;
                    last--;
                }
            }
            if (firstIndex < last)
            {
                QuickSort(arr, firstIndex, last);
            }
            if (first < lastIndex)
            {
                QuickSort(arr, first, lastIndex);
            }
            return arr;
        }
    }
}
