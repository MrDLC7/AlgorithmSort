using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    internal class Generate : AlgorithmSort
    {
        private long time;          //  Час генерації в мк.

        public long Time { get => time; }

        public Generate(IComparable[] array, int size, int max_number)
        {
            Random random = new Random();
            Stopwatch stopwatch = Stopwatch.StartNew();
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(max_number) - random.Next(max_number);
            }
            stopwatch.Stop();
            time = stopwatch.ElapsedTicks / (Stopwatch.Frequency / (1000L * 1000L));
        }
    }
}
