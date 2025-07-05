using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Daily_Questions
{
    internal class Find_Subsequence_of_Length_K_With_the_Largest_Sum
    {
        public int[] MaxSubsequence(int[] nums, int k)
        {
            if (k == nums.Length) return nums;
            if (k < nums.Length)
            {
                int[] subsequence = new int[k];
                nums = InsertSortArray(nums);
                int j = nums.Length - k;
                for (int i = 0; i <=  k - 1; i++)
                {
                    subsequence[i] = nums[j];
                    j++;
                }
                return subsequence;
            }
                return new int[0];
        }

        private int[] InsertSortArray(int[] nums) {
            for (int i = 1; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && key < nums[j] )
                {
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = key; 
            }
            return nums;
        }

    }
}
