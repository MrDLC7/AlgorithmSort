using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AlgorithmSort
{
    internal class Print : AlgorithmSort
    {
        static private string separate = "-------------------------------------------------------------------";

        //  Виведення дій (Лог)
        static public string InfoLog(string name, int size, long time, string unit)
        {
            return $"\"{name}\"\nКількість елементів: {size}\nЧас: {time} {unit}." + InfoLogSeparation();
        }

        //  Очищення (Лог)
        static public string InfoLogReset()
        {
            return "";
        }

        //  Виведення "Масив"
        static public string InfoArray(string? details, object[] nums)
        {
            string output = string.Empty;
            int i = 1;
            output = details + ":\n\n";
            foreach (var item in nums)
            {
                output += item.ToString() + '\t' + ((i % 7  == 0) ? "\n": " ");
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
            return $"\n\n{separate}\n{separate}\n\n";
        }
    }
}
