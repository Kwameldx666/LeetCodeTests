using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class Sort
    {
        public int[] BubleSortReverse(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        var tmp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = tmp;
                    }
                }
            }
            return nums;
        }


        public int[] InsertSort(int[] nums)
        {
            int n = nums.Length;
            for (int i = 1; i < n; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && key < nums[j])
                {
                    nums[j + 1] = nums[j];
                    j--; ;
                }
                nums[j + 1] = key;
            }
            return nums;
        }
    }
}


