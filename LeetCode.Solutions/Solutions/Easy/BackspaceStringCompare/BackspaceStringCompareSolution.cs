using System.Collections.Generic;
using System.Text;

namespace LeetCode.Solutions.Solutions.Easy.BackspaceStringCompare
{
    /// <summary>
    /// https://leetcode.com/problems/backspace-string-compare/
    /// </summary>
    public class BackspaceStringCompareSolution
    {
        public bool BackspaceCompare(string s, string t)
        {
            var s_stack = Slice(s);
            var t_stack = Slice(t);

            if (s_stack.Count != t_stack.Count)
            {
                return false;
            }

            while (s_stack.TryPop(out var s_pop))
            {
                if (s_pop != t_stack.Pop())
                {
                    return false;
                }
            }

            return true;
        }

        private Stack<char> Slice(string s)
        {
            var result = new Stack<char>();

            foreach (var c in s)
            {
                if (c == '#')
                {
                    result.TryPop(out _);

                    continue;
                }

                result.Push(c);
            }

            return result;
        }
    }
}
