using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*Given an array of unsorted numbers, check if all the numbers in the array are consecutive numbers.  

For example:
1. If array is [5, 2, 3, 1, 4], then the function should return true because the array has consecutive numbers from 1 to 5 (1,2,3,4,5).
2.  If the array is [34, 23, 52, 12, 3], then the function should return false because the elements are not consecutive.
3.  If the array is [7, 6, 5, 5, 3, 4], then the function should return false because 5 and 5 are not consecutive.
Given an array of unsorted numbers, check if all the numbers in the array are consecutive numbers. */



namespace LeetCodeTests.Daily_Questions
{
    internal class Third_Task
    {
        public bool CheckSequal(int[] arr)
        {
            if (ArrayLength(arr) == 0) return false;
            if (ArrayLength(arr) == 1) return true;
            arr = InsertSort(arr);
            for (int i = 1; i < ArrayLength(arr); i++)
            {
                if (arr[i] - arr[i - 1] != 1)
                    return false;

            }
            return true;
        }        

        private int ArrayLength(int[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                count++;
            }
            return count;
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
    }
}
