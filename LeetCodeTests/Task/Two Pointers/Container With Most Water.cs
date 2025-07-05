using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Two_Pointers
{
    internal class Container_With_Most_Water
    {
        public int MaxArea(int[] height)
        {
            int maxArea = 0;
            int start = 0, end = height.Length - 1;
            while (start < end)
            {
                maxArea = Math.Max(maxArea, CalculateMaxArea(height, start, end));
                if (height[start] < height[end])
                {
                    start++;
                }
                else
                {
                    end--;
                }

            }
            return maxArea;
        }

        private int CalculateMaxArea(int[] height, int start, int end)
        {
            int max = height[start] > height[end] ? height[end] : height[start];
            return (end - start) * max;
        }
    }

}
