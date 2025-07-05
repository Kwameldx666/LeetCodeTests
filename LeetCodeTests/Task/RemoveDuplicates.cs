using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    public class RemoveDubl
    {
        //    //  /*  public int RemoveDuplicates(int[] nums)
        //    //    {
        //    //        int length = nums.Length - 1;
        //    //        int count, answer = 0, j = 0, i;
        //    //        List<bool> flags = new(length);
        //    //        List<int> ints = new(length);

        //    //        i = j;
        //    //        if (j + 1 < length)
        //    //        {
        //    //            j++;
        //    //        }
        //    //        else
        //    //        {
        //    //            flags.Add(false);
        //    //        }
        //    //        if (nums[i] != nums[j])
        //    //        {
        //    //            flags.Add(false);
        //    //            ints.Add(nums[i]);
        //    //            ints.Add(nums[j]);

        //    //        }
        //    //        else
        //    //            flags.Add(false);
        //    //        while (nums[i] == nums[j] && flags.Count > 0)
        //    //        {
        //    //            flags[flags.Count - 1] = true;
        //    //            ints[i] = nums[i];
        //    //            ints[i + 1] = nums[i + 1];
        //    //            j++;
        //    //        }

        //    //        foreach (bool c in flags)
        //    //        {
        //    //            if (c == true)
        //    //            {
        //    //                answer += 2;
        //    //            }
        //    //            else if (c == false) { answer++; }
        //    //        }
        //    //        return answer;

        //    //    }
        //    //}*/


        //}



        /*     public int RemoveDuplicates(int[] nums)
             {
                 if (nums == null || nums.Length == 0)
                 {
                     return 0;
                 }

                 int i = 0, count = 0;
                 for (int j = 1; j < nums.Length; j++)
                 { 
                     while (nums[i] == nums[j] && count < 2)
                     {
                         j++;
                         count++;
                     };
                     if(count == 2)
                     {
                         count = 1;
                         i = j;
                     }
                     if (nums[j] != nums[i])
                     {
                         nums[i] = nums[j];
                         count++;
                     }
                     else
                         i = j;

                 }
                 return i + 1;
             }*/
        public int RemoveDuplicates(int[] nums)
        {
            int i = 2;
            if (nums.Length <= 2) return nums.Length;
            for (int j = 2; j < nums.Length; j++)
            {
                if (nums[j] != nums[i - 2])
                {
                    nums[i] = nums[j];
                    i++;
                }
            }
            return i;
        }
    }
}