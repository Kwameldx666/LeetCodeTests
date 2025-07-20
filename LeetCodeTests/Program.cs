
using LeetCodeTests.Daily_Questions;
using LeetCodeTests.Helpful_tasks;
using LeetCodeTests.Repeat_and_learn;
using LeetCodeTests.Task.Array_and_String;
using System;
namespace LeetCodeTests.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Zigzag_Conversion zigzag_Conversion = new Zigzag_Conversion();
            string s = "PAYPALISHIRING";
            int numRows = 4;
            var res = zigzag_Conversion.Convert(s, numRows);
         
                Console.WriteLine(res.CompareTo("PINALSIGYAHRPI"));
            






        }
    }
}