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

        #region BubbleSort

        //  Сортування бульбашкою Start
        public void Bubble(IComparable[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            BubbleSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування бульбашкою
        private void BubbleSort(IComparable[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        swap(array, j, j + 1);
                    }
                }
            }
        }

        #endregion BubbleSort


        #region InsertSort

        //  Сортування вставками Start
        public void Insert(IComparable[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            InsertSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування вставками
        private void InsertSort(IComparable[] array)
        {

            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                IComparable key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }

        #endregion InsertSort


        #region MergeSort

        //  Сортування злиттям Start
        public void Merge(IComparable[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            MergeSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування злиттям
        private void MergeSort(IComparable[] array)
        {
            int n = array.Length;
            if (n > 1)
            {
                int mid = n / 2;
                IComparable[] left = new IComparable[mid];
                IComparable[] right = new IComparable[n - mid];
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
                Merging(array, left, right);
            }
        }

        //  Злиття
        private void Merging(IComparable[] array, IComparable[] left, IComparable[] right)
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) <= 0)
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }

        #endregion MergeSort


        #region QuickSort

        //  Швидке сортування Start
        public void Quick(IComparable[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Швидке сортування
        private void QuickSort(IComparable[] array, int left, int right)
        {
            int i, last;
            if (left >= right)                          //  Якщо менше двох елементів у масиві
                return;
            swap(array, left, (left + right) / 2);      //  Середній елемент
            last = left;                                //  На початок
            for (i = left + 1; i <= right; i++)         //  Ділення на частини
                if (array[i].CompareTo(array[left]) <= 0)
                    swap(array, ++last, i);
            swap(array, left, last);                    //  Перевизначення середнього елементу
            QuickSort(array, left, last - 1);
            QuickSort(array, last + 1, right);
        }

        #endregion QuickSort

        //  Обмін місцями елементів масиву
        private void swap(IComparable[] array, int left, int right)
        {
            IComparable temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
