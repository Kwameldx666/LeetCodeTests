using System;

namespace LeetCodeTests.Task.Two_Pointers
{
    internal class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            int c = s.Length;
            int i = 0, j = s.Length - 1;
            while (i < j)
            {
                while (i < j && !char.IsLetterOrDigit(s[i])) i++;
                while (i < j && !char.IsLetterOrDigit(s[j])) j--;
                if (i < j)
                {
                    if (char.ToLower(s[i]) != char.ToLower(s[j]))
                        return false;
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}