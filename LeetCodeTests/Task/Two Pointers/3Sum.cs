using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Two_Pointers
{
    internal class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>();
            if (nums.Length < 3)
            {
                return new List<IList<int>>();
            }
            var SortArray = InsertSort(nums);
            for (int i = 0; i < nums.Length - 2; i++) // перебираешь все первые элементы
            {
                if (i > 0 && nums[i] == nums[i - 1]) continue;
                int left = i + 1;           // левый указатель
                int right = nums.Length - 1; // правый указатель
                var res1 = nums[i] * -1;

                while (left < right)        // ищешь пару для nums[i]
                {
                    var res2 = nums[left] + nums[right];
                    while (left < right && nums[left] == nums[left - 1]) left++;
                    while (left < right && nums[right] == nums[right + 1]) right--;
                    if (res1 == res2)
                    {
                        list.Add(new int[] { nums[i], nums[left], nums[right] });
                        left++;
                        right--;
                    }
                }
            }

            return list;

        }

        public int[] InsertSort(int[] nums)
        {
            for (int i = 1; i <= nums.Length - 1; i++)
            {
                int key = nums[i];
                int j = i - 1;
                while (j >= 0 && key < nums[j])
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
