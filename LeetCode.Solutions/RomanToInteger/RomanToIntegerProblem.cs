using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.RomanToInteger
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class RomanToIntegerProblem
    {
        private readonly Dictionary<char, int> _romanNumbers = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public int RomanToInt(string s)
        {
            if (s.Length == 0)
            {
                return 0;
            }

            if (s.Length == 1)
            {
                if (_romanNumbers.ContainsKey(s[0]))
                {
                    return _romanNumbers[s[0]];
                }
                else
                {
                    return 0;
                }
            }

            var arr = s.ToUpper().ToCharArray();

            var results = new Stack<int>();

            foreach (var c in arr)
            {
                var value = _romanNumbers[c];

                if (results.Count > 0)
                {
                    var last = results.Peek();

                    if (last < value)
                    {
                        value -= last;
                        results.Pop();
                    }
                }

                results.Push(value);
            }

            return results.Sum();
        }
    }
}
