using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Sliding_Window
{
    internal class Minimum_Size_Subarray_Sum
    {
        //Вход: target = 7, nums = [2,3,1,2,4,3]
        public int MinSubArrayLen(int target, int[] nums)
        {
            int left = 0;
            int sum = 0;
            int minLength = int.MaxValue;
            for (int right = 0; right < nums.Length; right++)
            {
                sum += nums[right];
                while (sum >= target)
                {
                    minLength = Math.Min(minLength, right - left + 1);
                    sum -= nums[left];
                    left++;
                }
            }
            return minLength == int.MaxValue ? -1 : minLength;
        }
    }
}
