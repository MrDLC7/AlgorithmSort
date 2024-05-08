﻿using System;
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

        //  Сортування бульбашкою
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

        //  Сортування вставками
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

        //  Сортування злиттям Початок
        public void Merge<T>(T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            MergeSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування злиттям
        private void MergeSort<T>(T[] array) where T : IComparable<T>
        {
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
                Merging(array, left, right);
            }
        }

        //  Злиття
        private void Merging<T>(T[] array, T[] left, T[] right) where T : IComparable<T>
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

        //  Швидке сортування Початок
        public void Quick<T>(T[] array) where T : IComparable<T>
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Швидке сортування
        private void QuickSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            int i, last;
            if (left >= right)                          //  Якщо менше двох елементів у масиві
                return;            
            swap(array, left, (left + right) / 2);      //  Середній елемент
            last = left;                                //  На початок
            for (i = left + 1; i <= right; i++)         //  Ділення на частини
                if (array[i].CompareTo(array[left]) > 0)
                    swap(array, ++last, i);
            swap(array, left, last);                    //  Перевизначення середнього елементу
            QuickSort(array, left, last - 1);
            QuickSort(array, last + 1, right);
        }

        //  Обмін місцями елементів масиву
        private void swap<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            T temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}