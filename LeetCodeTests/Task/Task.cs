using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task4
{//Median of Two Sorted Arrays
    public class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int Length 
                = nums1.Length + nums2.Length;
            if (Length % 2 == 0)
            {
                return (calcualteMedian(nums1, 0, nums2, 0, Length / 2)
                     + calcualteMedian(nums1, 0, nums2, 0, Length / 2 + 1)) / 2.0;
            }
            else
            {
                return calcualteMedian(nums1, 0, nums2, 0, Length / 2 + 1);
            }

        }
        private double calcualteMedian(int[] nums1, int start1, int[] nums2, int start2, int k)
        {
            int mid1, mid2 = 0;
            if (start1 >= nums1.Length) { return nums2[start2 + k - 1]; }
            if (start2 >= nums2.Length) { return nums1[start1 + k - 1]; }
            if (k == 1)
            {
                return Math.Min(nums1[start1], nums2[start2]);
            }
            mid1 = (start1 + k / 2 - 1 < nums1.Length) ? nums1[start1 + k / 2 - 1] : int.MaxValue;
            mid2 = (start2 + k / 2 - 1 < nums2.Length) ? nums2[start2 + k / 2 - 1] : int.MaxValue;
            if (mid1 < mid2)
            {
                start1 += k / 2;
                k -= k / 2;
                return calcualteMedian(nums1, start1, nums2, start2, k);
            }
            else
            {
                start2 += k / 2;
                k -= k / 2;
                return calcualteMedian(nums1, start1, nums2, start2, k);
            }
        }
    }
}