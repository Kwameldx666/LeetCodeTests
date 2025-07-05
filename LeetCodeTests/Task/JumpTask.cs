using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class JumpTask
    {
        public bool CanJump(int[] nums)
        {
            int farthest = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > farthest)
                    return false; // не можем дойти до этой позиции

                farthest = Math.Max(farthest, i + nums[i]);
                if (farthest >= nums.Length - 1)
                    return true; // уже можем дойти до конца
            }
            return true;
        }
    }
}
