using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task
{
    internal class ReverseBitsTask
    {
        // Reverse the bits of a given 32 bits unsigned integer.
        public uint reverseBits(uint n)
        {
            uint res = 0;
            for (int i = 0; i < 32; i++)
            {
                res <<= 1;
                res |= (n & 1); 
                n >>= 1;
            }
            return res;
        }
    }
}
