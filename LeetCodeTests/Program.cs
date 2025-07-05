
using LeetCodeTests.Repeat_and_learn;

using System;
namespace LeetCodeTests.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat_and_learn.BankQueue<int> queue = new Repeat_and_learn.BankQueue<int>();
            queue.Enter(101);
            queue.Enter(102);
            queue.Enter(103);
            queue.ServicePeople();

        }
    }
}