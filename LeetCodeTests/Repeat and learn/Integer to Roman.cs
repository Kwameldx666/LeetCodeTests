using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Repeat_and_learn
{
    internal class Integer_to_Roman
    {
        public string IntToRoman(int num)
        {
            // Значения и соответствующие им римские цифры
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            var sb = new StringBuilder();

            for (int i = 0; i < values.Length; i++)
            {
                // Пока num достаточен для текущего «римского» значения
                while (num >= values[i])
                {
                    num -= values[i];       // вычитаем
                    sb.Append(symbols[i]);  // добавляем символ
                }
            }

            return sb.ToString();
        }
    }
}
