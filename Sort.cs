using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    internal class Sort : AlgorithmSort
    {
        private long time;

        public long Time { get => time; }

        //  
        public void Bubble<T>(T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        T temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  
        public void Insert<T>(T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                T key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        public void MergeSort<T>(T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            int n = array.Length;
            if (n > 1)
            {
                int mid = n / 2;
                T[] left = new T[mid];
                T[] right = new T[n - mid];
                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }
                for (int i = mid; i < n; i++)
                {
                    right[i - mid] = array[i];
                }
                MergeSort(left);
                MergeSort(right);
                Merge(array, left, right);
            }
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        private void Merge<T>(T[] array, T[] left, T[] right) where T : IComparable<T>
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }
            while (i < left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < right.Length)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
