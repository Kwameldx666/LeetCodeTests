using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
/*Input: gas = [1, 2, 3, 4, 5], cost = [3, 4, 5, 1, 2]
Output: 3
Explanation:
Start at station 3 (index 3) and fill up with 4 unit of gas. Your tank = 0 + 4 = 4
Travel to station 4. Your tank = 4 - 1 + 5 = 8
Travel to station 0. Your tank = 8 - 2 + 1 = 7
Travel to station 1. Your tank = 7 - 3 + 2 = 6
Travel to station 2. Your tank = 6 - 4 + 3 = 5
Travel to station 3. The cost is 5. Your gas is just enough to travel back to station 3.
Therefore, return 3 as the starting index.*/
namespace LeetCodeTests.Task.Array_and_String
{
    public class Gas_Station
    {
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas == null || cost == null || gas.Length != cost.Length) return -1;

            int total = 0, tank = 0, start = 0;
            for (int i = 0; i < gas.Length; i++)
            {
                int diff = gas[i] - cost[i];
                total += diff;
                tank += diff;
                if (tank < 0)
                {
                    start = i + 1;
                    tank = 0;
                }
            }
            return total >= 0 ? start : -1;
        }

      
    }
}
