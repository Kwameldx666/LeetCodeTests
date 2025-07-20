using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Task.Array_and_String
{
    internal class Reverse_Words_in_a_String
    {
        public string ReverseWords(string s)
        {
            s = s.ToLower().Trim();
            Stack<string> words = new Stack<string>();
            int i = 0;
            string top = "";
            while (i < s.Length)
            {
                while (s[i] == ' ') { i++; }   
                StringBuilder tmp = new();
                while (i < s.Length && s[i] != ' ' )
                {
                    tmp .Append(s[i]);
                    i++;
                }

                words.Push(tmp.ToString());
                i++;
            }
            while (words.Count > 0)
            {
                 top += words.Pop() + " ";  
                
            }
            top = top.TrimEnd();
            return top;

        }
    }
}
