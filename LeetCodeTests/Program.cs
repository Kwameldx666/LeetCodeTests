
using LeetCodeTests.Repeat_and_learn;

using System;
namespace LeetCodeTests.Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Heap heap = new(9);
            heap.Insert(100);
            heap.Insert(36);
            heap.Insert(19);
            heap.Insert(25);
            heap.Insert(3);
            heap.Insert(7);
            heap.Insert(2);
            heap.Insert(1);
            heap.Insert(17);
            var res = heap.GetSortArray();
            foreach (var item in res)
            {
                Console.WriteLine(item.ToString());
            }




        }
    }
}