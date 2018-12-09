using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_Task1
{
     public class Sort
    {
        public static int[] InsertionSort(int[] mass, out int c)
        {
            //int n = mass.Length;
            //лучший случай : n-1, худший случай : n*(n-1)/2
            c = 0;
            bool NotAdded = true;
            int[] result = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                int j = i;
                while (j > 0 && result[j - 1] > mass[i])
                {
                    c++;
                    NotAdded = false;
                    result[j] = result[j - 1];
                    j--;
                }
                if (NotAdded)
                    c++;
                if (j == 0 && i == 0)
                    c--;
                NotAdded = true;
                result[j] = mass[i];
            }
            return result;
        }
        public static int[] BinaryInsertionSort(int[] mass, out int c)
        {
            c = 0;
            int k, j, m, left, right, x;
            for (k = 1; k < mass.Length; k++)
            {
                x = mass[k]; left = 0; right = k;
                while (left < right)                                        //пока есть что просматривать 
                {
                    c++;
                    m = (left + right) / 2;                                  //делим интервал поиска пополам 
                    if (mass[m] <= x)                                        //если вставляемое значение больше текущего
                    {
                        left = m + 1;                                        //искать надо в правой части 
                    }
                    else
                    {
                        right = m;                                           //а если нет, то будем искать в левой 
                    }
                }
                for (j = k; j > right; mass[j--] = mass[j]) ;
                mass[right] = x;
            }
            return mass;
        }

        public static int[] SortBubl(int[] b, out int c, out int swap)
        {
            int n = b.Length;
            c = 0;
            swap = 0;
            for (int i = 1; i <= n - 1; i++)
            {
                for (int j = n - 1; j >= i; j--)
                {
                    if (b[j - 1] > b[j])
                    {
                        int t = b[j - 1];
                        b[j - 1] = b[j];
                        b[j] = t;
                        swap++;
                    }
                    c++;
                }
                if (swap == 0 && c == n - 1)
                    break;
            }
            return b;
        }


        public static int[] ShellSort(int[] mass, int d, out int c, out int swap)
        {
            int[] result = new int[mass.Length];
            c = 0;
            swap = 0;
            int j;
            while (d > 0)
            {
                for (int i = 0; i < (mass.Length - d); i++)
                {
                    j = i;
                    while ((j >= 0) && (mass[j] > mass[j + d]))
                    {
                        c++;
                        int tmp = mass[j];
                        mass[j] = mass[j + d];
                        mass[j + d] = tmp;
                        j -= d;
                        swap++;
                    }
                    c++;
                }
                d = d / 2;
            }
            return mass;
        }

        public static int[] MergeSort(int[] mass, ref int c)
        {
            if (mass.Length == 1)
                return mass;
            int mid_point = mass.Length / 2;
            return Merge(MergeSort(mass.Take(mid_point).ToArray(), ref c), MergeSort(mass.Skip(mid_point).ToArray(), ref c), ref c);
        }

        private static int[] Merge(int[] mass1, int[] mass2, ref int c)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                {
                    if (mass1[a] > mass2[b])
                    {
                        c++;
                        merged[i] = mass2[b++];
                    }
                    else
                    {
                        c++;
                        merged[i] = mass1[a++];
                    }
                }
                else
                {
                    if (b < mass2.Length)
                    {
                        merged[i] = mass2[b++];
                    }
                    else
                    {
                        merged[i] = mass1[a++];
                    }
                }
            }
            return merged;
        }
        
        public static int[] QuickSort(int[] mass, int first, int last, ref int c)
        {
            if (first < last)
            {
                int left = first, right = last, middle = mass[(left + right) / 2];
                do
                {
                    while (mass[left] < middle)
                    {
                        c++;//////////////////////////счетчик
                        left++;
                    }
                    while (mass[right] > middle)
                    {
                        c++;//////////////////////////счетчик
                        right--;
                    }
                    if (left <= right)
                    {
                        int tmp = mass[left];
                        mass[left] = mass[right];
                        mass[right] = tmp;
                        left++;
                        right--;
                    }
                }
                while (left <= right);
                QuickSort(mass, first, right, ref c);
                QuickSort(mass, left, last, ref c);
            }
            return mass;
        }










    }
}
