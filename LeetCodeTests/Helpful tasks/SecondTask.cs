using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a function that, given an array of N integers, returns the smallest positive integer (greater than 0) that does not occur in array  

For example:  
Given [1, 3, 6, 4, 1, 2], the function should return 5.  
Given [1, 2, 3], the function should return 4.  
Given [−1, −3], the function should return 1.  Write a function that, given an array of N integers, returns the smallest positive integer (greater than 0) that does not occur in array  
 */
namespace LeetCodeTests.Helpful_tasks
{
    internal class SecondTask
    {
        public int SmallestPositive(int[] array)
        {
            int[] sorted = InsertSort(array);
            int smallest = 1; // начинаем с 1 — минимального положительного

            for (int i = 0; i < sorted.Length; i++)
            {
                if (sorted[i] == smallest)
                {
                    smallest++; // если число найдено, ищем следующее
                }
            }

            return smallest;
        }

        private int[] InsertSort(int[] array)
        {
            for (int i = 1; i < ArrayLength(array); i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;

            }
            return array;
        }
    };




}
