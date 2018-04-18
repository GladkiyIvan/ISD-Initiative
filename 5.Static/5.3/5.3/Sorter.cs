namespace _5._3
{
    static class Sorter
    {
        public static void Sort(this int[] arr, bool whatWay)
        {
            if (whatWay == true)
            {
                SortAscending(arr, 0, arr.Length - 1);
            }
            else
            {
                SortDescending(arr, 0, arr.Length - 1);
            }
        }
        static void SortDescending(int []a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] < num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] > num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            SortDescending(a, start, i - 1);
            SortDescending(a, i + 1, end);
        }
        static void SortAscending(int []a, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            SortAscending(a, start, i - 1);
            SortAscending(a, i + 1, end);
        }
    }
}
