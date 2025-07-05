using System;
using System.Collections.Generic;

public class RandomizedSet
{
    private List<int> nums;
    private Dictionary<int, int> dict;
    private Random rand;

    public RandomizedSet()
    {
        nums = new List<int>();
        dict = new Dictionary<int, int>();
        rand = new Random();
    }

    public bool Insert(int val)
    {
        if (dict.ContainsKey(val))
            return false;
        dict[val] = nums.Count;
        nums.Add(val);
        return true;
    }

    public bool Remove(int val)
    {
        if (!dict.ContainsKey(val))
            return false;
        int idx = dict[val];
        int last = nums[nums.Count - 1];
        nums[idx] = last;
        dict[last] = idx;
        nums.RemoveAt(nums.Count - 1);
        dict.Remove(val);
        return true;
    }

    public int GetRandom()
    {
        int idx = rand.Next(nums.Count);
        return nums[idx];
    }
}