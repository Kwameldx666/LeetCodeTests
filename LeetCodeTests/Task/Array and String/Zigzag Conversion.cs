using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Array_and_String
{
    internal class Zigzag_Conversion
    {
            public string Convert(string s, int numRows)
            {
                if (numRows <= 1 || s.Length <= numRows)
                    return s;

                var result = new List<char>(s.Length);
                int cycleLen = 2 * numRows - 2;

                // Проходим по каждой "строке" в зигзаге
                for (int row = 0; row < numRows; row++)
                {
                    // первый индекс символа в этой строке
                    int idx = row;

                    // если это крайняя сверху или снизу строка — шаг всегда cycleLen
                    int step1 = cycleLen - 2 * row;
                    int step2 = 2 * row;

                    bool useStep1 = true;
                    while (idx < s.Length)
                    {
                        result.Add(s[idx]);

                        // для первой и последней строки используем только один и тот же шаг
                        if (row == 0 || row == numRows - 1)
                        {
                            idx += cycleLen;
                        }
                        else
                        {
                            // средние строки: чередуем шаги
                            if (useStep1 && step1 > 0)
                            {
                                idx += step1;
                            }
                            else if (!useStep1 && step2 > 0)
                            {
                                idx += step2;
                            }
                            else
                            {
                                // на случай, если один из шагов равен 0
                                idx += cycleLen;
                            }

                            useStep1 = !useStep1;
                        }
                    }
                }

                return new string(result.ToArray());
            }
    }

}

