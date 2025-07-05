using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Two_Pointers
{
    internal class Two_Sum_II___Input_Array_Is_Sorted
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int a = 0; int b;
            while (a < numbers.Length - 1)
            {
                b = a + 1;
                while (b < numbers.Length)
                {
                    if (numbers[a] + numbers[b] == target)
                        return [a + 1, b + 1];
                    b++;
                }
                a++;
            }
            return [];
        }

        public int[] TwoSum2Solution(int[] numbers, int target)
        {
            int a = 0; int b = numbers.Length - 1;
            while (a < b)
            {
                if (numbers[a] + numbers[b] == target) return [a + 1, b + 1];
                if (numbers[a] + numbers[b] > target)
                {
                    b--;
                }
                else if (numbers[a] + numbers[b] < target)
                {
                    a++;
                }
            }
            return [];
        }
    }
}
