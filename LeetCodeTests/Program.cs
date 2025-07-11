
using LeetCodeTests.Repeat_and_learn;
using LeetCodeTests.Task.Array_and_String;
using System;
namespace LeetCodeTests.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Gas_Station gasstation = new Gas_Station();
            int[] gas = new int[] { 5, 8, 2, 8 };
            int[] cost = new int[] { 6, 5, 6, 6 };

            Console.WriteLine(gasstation.CanCompleteCircuit(gas, cost));




        }
    }
}