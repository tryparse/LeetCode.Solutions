using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindrome/
    /// </summary>
    public class LongestPalindromeSolution
    {
        public int LongestPalindrome(string s)
        {
            if (s.Length < 2)
            {
                return s.Length;
            }

            var dictionary = new Dictionary<char, int>();

            foreach (var c in s)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary[c] = 1;
                }
            }

            var even = dictionary.Values
                .Where(x => x % 2 == 0)
                .Sum();

            var maxOddChar = dictionary
                .Where(x => x.Value % 2 != 0)
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .FirstOrDefault();

            var odd = dictionary
                .Where(x => x.Value % 2 != 0)
                .Select(x => x.Key == maxOddChar ? x.Value : Math.Max(x.Value - 1, 0))
                .Sum();

            return even + odd;
        }
    }
}
