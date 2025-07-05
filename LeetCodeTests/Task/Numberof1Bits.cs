using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class Numberof1Bits
    {//Calculate the number of 1 bits in the binary representation of an integer.
        public int HammingWeight(int n)
        {

           
            int count = 0;
            while (n > 0)
            {
                count += n & 1;
                n >>= 1;
            }
            return count;
        }
    
    }
}
