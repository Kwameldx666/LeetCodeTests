
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
            Third_Task first_Task = new Third_Task();
            int[] array = { 1,2,3,5};
            var res = first_Task.CheckSequal(array);

            Console.WriteLine(res);





        }
    }
}