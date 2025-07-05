using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Daily_Questions
{
    internal class Longest_Harmonious_Subsequence
    {
        public int FindLHS(int[] nums)
        {
            var count = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!count.ContainsKey(num))
                    count[num] = 0;
                count[num]++;
            }
            int max = 0;
            foreach (var key in count.Keys)
            {
                if (count.ContainsKey(key + 1))
                {
                    max = Math.Max(max, count[key] + count[key + 1]);
                }
            }
            return max;
        }
    }
}

