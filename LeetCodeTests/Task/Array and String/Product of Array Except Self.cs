using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Array_and_String
{
    internal class Product_of_Array_Except_Self
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var tmpResult = new int[nums.Length];
            int[] result = new int[nums.Length];
            tmpResult[nums.Length - 1] = result[0] = 1;
            for(int i = 1;i < nums.Length;i++)
            {
                result[i] = nums[i - 1] * result[i - 1];    
            }
            for(int i = nums.Length - 2; i >= 0; i--)
            {
                tmpResult[i] = tmpResult[i+1] * nums[i + 1];
                result[i] = result[i] * tmpResult[i];
            }
            return result;
        }
    }
}
