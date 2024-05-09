using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmSort
{
    internal class Print : AlgorithmSort
    {
        static private string separate = "----------------------------------------------------------";

        //  Виведення дій (Лог)
        static public string InfoLog(string name, int size, long time, string unit)
        {
            return $"\"{name}\"\nКількість елементів: {size}\nЧас сортування: {time} {unit}.\n\n" + InfoLogSeparation();
        }

        //  Очищення (Лог)
        static public string InfoLogReset()
        {
            return "";
        }

        //  Виведення "Масив"
        static public string InfoArray(object[] nums)
        {
            string output = string.Empty;
            int i = 0;
            foreach (var item in nums)
            {
                output += $"{item}" + ((i % 15 == 0) ? "\n": "  ");
                i++;
            }
            output += InfoLogSeparation();
            return output;
        }

        //  Очищення "Масив"
        static public string InfoArrayReset()
        {
            return "";
        }

        //  Розділення "Лог" після кожної виконаної дії
        static public string InfoLogSeparation()
        {
            return $"\n{separate}\n{separate}\n\n";
        }
    }
}
