using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class StrTask
    {

        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
                return 0;

            if (haystack.Length < needle.Length)
                return -1;

            for (int start = 0; start <= haystack.Length - needle.Length; start++)
            {
                int j = 0;
                while (j < needle.Length && haystack[start + j] == needle[j])
                {
                    j++;
                }
                if (j == needle.Length)
                {
                    return start;
                }
            }
            return -1;


            /*public int StrStr(string haystack, string needle)
            {
                if (string.IsNullOrEmpty(needle))
                    return 0;
                if (needle.Length > haystack.Length)
                    return -1;

                for (int start = 0; start <= haystack.Length - needle.Length; start++)
                {
                    int j = 0;
                    while (j < needle.Length && haystack[start + j] == needle[j])
                    {
                        j++;
                    }
                    if (j == needle.Length)
                        return start;
                }
                return -1;
            }*/
        }
    }
}
