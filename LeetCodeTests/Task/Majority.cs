using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class Majority
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            foreach (int num in nums)
            {
                if (map.ContainsKey(num))
                {
                    map[num] += 1;
                }
                else
                {
                    map[num] = 1;
                }
            }
            return map.OrderByDescending(x => x.Value).First().Key;
        }
    }
}