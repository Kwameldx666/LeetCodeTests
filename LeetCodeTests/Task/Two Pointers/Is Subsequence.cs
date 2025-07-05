using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Two_Pointers
{
    internal class Is_Subsequence
    {
        /*     Input: s = "abc", t = "ahbgdc"
               Output: true                            */
        public bool  IsSubsequence(string s, string t)
        {
            int j = 0; int i = 0;
            while (j < s.Length && i < t.Length)
            {
                if (s[j] == t[i])
                    j++;
                i++;
            }
            return j == s.Length;
        }
    }
}
