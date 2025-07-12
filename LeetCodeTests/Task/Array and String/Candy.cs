using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Example 1:

Input: ratings = [1, 0, 2]
Output: 5
Explanation: You can allocate to the first, second and third child with 2, 1, 2 candies respectively.
Example 2:

Input: ratings = [1, 2, 2]
Output: 4
Explanation: You can allocate to the first, second and third child with 1, 2, 1 candies respectively.
The third child gets 1 candy because it satisfies the above two conditions.*/
namespace LeetCodeTests.Task.Array_and_String
{
    internal class CandyGame
    {
        public int Candy(int[] ratings)
        {
            int[] candies = new int[ratings.Length];
            Array.Fill(candies, 1);
            int n = ratings.Length - 2;
            for(int i = 0; i <= n; i++)
            {
                if (ratings[i] < ratings[i + 1])
                {
                    candies[i + 1] = candies[i] + 1; 
                }            
            }
            for (int i = n; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = int.Max(candies[i + 1] + 1, candies[i]);
                }
            }
            return candies.Sum();
        }
    }
}

