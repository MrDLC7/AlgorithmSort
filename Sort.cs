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
            //  Запуск сортування
            BubbleSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування бульбашкою
        //  Проходить по масиву, порівнюючи кожну пару сусідніх елементів і, при необхідності, міняє їх місцями
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
            //  Запуск сортування
            InsertSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування вставками
        //  Елементи вставляються на відповідні місця у вже відсортованій частині масиву
        private void InsertSort(IComparable[] array)
        {

            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                //  Збереження поточного елементу
                IComparable key = array[i];             
                int j = i - 1;
                //  Переміщення всіх більших елементів за поточний на одну позицію вперед
                while (j >= 0 && array[j].CompareTo(key) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                //  Вставленняо поточного елементу у відповідне місце
                array[j + 1] = key;
            }
        }

        #endregion InsertSort


        #region MergeSort

        //  Сортування злиттям Start
        public void Merge(IComparable[] array)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            //  Запуск сортування
            MergeSort(array);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Сортування злиттям
        //  Рекурсивно розділяє масив навпіл та об'єднує його підмасиви за допомогою методу Merging
        private void MergeSort(IComparable[] array)
        {
            int n = array.Length;
            if (n > 1)
            {
                int mid = n / 2;
                IComparable[] left = new IComparable[mid];
                IComparable[] right = new IComparable[n - mid];
                //  Ділимо масив на два підмасиви
                for (int i = 0; i < mid; i++)
                {
                    left[i] = array[i];
                }
                for (int i = mid; i < n; i++)
                {
                    right[i - mid] = array[i];
                }
                //  Рекурсивно сортуємо кожен з підмасивів
                MergeSort(left);
                MergeSort(right);
                //  Об'єднання відсортованих підмасивів
                Merging(array, left, right);
            }
        }

        //  Об'єднання відсортованих підмасивів left та right в один відсортований масив array.
        private void Merging(IComparable[] array, IComparable[] left, IComparable[] right)
        {
            int i = 0, j = 0, k = 0;
            //  Порівнюємо елементи лівого та правого підмасивів і об'єднуємо їх у один масив
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
            //  Додаємо залишок лівого підмасиву (якщо є)
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }
            //  Додаємо залишок правого підмасиву (якщо є)
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
            //  Запуск сортування
            QuickSort(array, 0, array.Length - 1);
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }

        //  Швидке сортування
        //  Рекурсивно розділяє масив навколо середнього елемента та сортує частини
        private void QuickSort(IComparable[] array, int left, int right)
        {
            int i, last;
            //  Якщо менше двох елементів у масиві -> Вийти
            if (left >= right)                          
                return;
            //  Середній елемент -> На початок
            swap(array, left, (left + right) / 2);      
            //  Початок робочого масиву
            last = left;                                 
            //  Ділення на частини
            for (i = left + 1; i <= right; i++)         
                if (array[i].CompareTo(array[left]) <= 0)
                    swap(array, ++last, i);
            //  Перевизначення середнього елементу
            swap(array, left, last);
            //  Рекурсивне сортування лівої частини                    
            QuickSort(array, left, last - 1);
            //  Рекурсивне сортування правої частини           
            QuickSort(array, last + 1, right);          
        }

        #endregion QuickSort

        //  Обмін місцями двох елементів масиву
        private void swap(IComparable[] array, int left, int right)
        {
            IComparable temp = array[left];
            array[left] = array[right];
            array[right] = temp;
        }
    }
}
