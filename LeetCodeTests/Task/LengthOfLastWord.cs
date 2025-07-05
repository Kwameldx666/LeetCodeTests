using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LeetCodeTests.Task
{
    /*    Пример 1:

    Ввод: s = "Hello World"
     Вывод: 5
     Пояснение: Последнее слово — "World" длиной 5.
    Пример 2:

    Ввод: s = "Отправь меня на луну"
     Вывод: 4
     Пояснение: Последнее слово - "луна" длиной 4.
    Пример 3:

    Ввод: s = "luffy is still joyboy"
     Вывод: 6
     Пояснение: Последнее слово — "joyboy" длиной 6.*/
    internal class LengthOfLastWordClass
    {
        public int LengthOfLastWord(string s)
        {
            int length = 0;
            int i = s.Length - 1;

            // Пропустить пробелы с конца
            while (i >= 0 && s[i] == ' ')
                i--;

            // Считаем буквы последнего слова
            while (i >= 0 && s[i] != ' ')
            {
                length++;
                i--;
            }

            return length;
        }


    }

}

