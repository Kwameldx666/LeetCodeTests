using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace LeetCodeTests.Task.Array_and_String
{
    internal class Trapping_Rain_Water
    {
        public int Trap(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int leftMax = 0, rightMax = 0, result = 0;
            while (left < right)
            {
                if (height[left] < height[right])
                {
                    if (height[left] >= leftMax)
                        leftMax = height[left];
                    else
                        result += leftMax - height[left];
                    left++;
                }
                else
                {
                    if (height[right] >= rightMax)
                        rightMax = height[right];
                    else
                        result += rightMax - height[right];
                    right--;
                }
            }
            return result;
        }
    }
}