using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*You are given a list/array which contains only integers (positive and negative). Your job is to sum only the numbers
that are the same and consecutive. The result should be one list.

You can assume there is never an empty list/array and there will always be an integer.

For example:  
Given [1,1,7,7,3] should return [2,14,3]  
Given [-5,-5,7,7,12,0] should return [-10,14,12,0]  
Given [1,4,4,4,0,4,3,3,1], the function should return [1,12,0,4,6,1]  You are given a list/array which contains only integers (positive and negative). Your job is to sum only the numbers
that are the same and consecutive. The result should be one list.

You can assume there is never an empty list/array and there will always be an integer.

For example:  
Given [1,1,7,7,3] should return [2,14,3]  
Given [-5,-5,7,7,12,0] should return [-10,14,12,0]  
Given [1,4,4,4,0,4,3,3,1], the function should return [1,12,0,4,6,1]  */
namespace LeetCodeTests.Helpful_tasks
{
    internal class First_Task
    {
        public List<int> SumEqual(int[] nums)
        {
            int start = 0;
            List<int> result = new List<int>();
            int sum = nums[start];
            for (int i = 1; i < nums.Length; i++)
            {
              
                if (nums[i] == nums[start])
                {
                    sum += nums[i];
                }
                else 
                {
                    result.Add(sum);
                    start = i;
                    sum = nums[start];
                }
               
            }
            result.Add(sum);
            return result;
        }
    }
}
