using System.Collections.Generic;

namespace LeetCode.Solutions.ValidParentheses
{
    public class ValidParenthesesProblem
    {
        private readonly Dictionary<char, char> _pairs = new Dictionary<char, char>()
        {
            {'{', '}'},
            {'(', ')'},
            {'[', ']'}
        };

        private readonly Stack<char> _stack = new Stack<char>();

        public bool IsValid(string s)
        {
            foreach (var c in s)
            {
                if (_pairs.ContainsKey(c))
                {
                    _stack.Push(c);
                }
                else if (_pairs.ContainsValue(c))
                {
                    if (_stack.TryPop(out var top))
                    {
                        if (_pairs[top] != c)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return _stack.Count == 0;
        }
    }
}
