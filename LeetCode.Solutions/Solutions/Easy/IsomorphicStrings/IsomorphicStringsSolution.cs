using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions.IsomorphicStrings
{
    /// <summary>
    /// https://leetcode.com/problems/isomorphic-strings/
    /// </summary>
    public class IsomorphicStringsSolution
    {
        public bool IsIsomorphic(string s, string t)
        {
            /*
             * Given two strings s and t, determine if they are isomorphic.
                Two strings s and t are isomorphic if the characters in s can be replaced to get t.
                All occurrences of a character must be replaced with another character while preserving the order of characters.
                No two characters may map to the same character, but a character may map to itself.
            */

            /*
             * Constraints:

                1 <= s.length <= 5 * 104
                t.length == s.length
                s and t consist of any valid ascii character.
            */

            /*
                Input: s = "egg", t = "add"
                Output: true

                [DataRow("badc", "baba", false)]
            */

            if (s.Length != t.Length)
            {
                return false;
            }

            if (s == t)
            {
                return true;
            }

            var replaceDictionary = new Dictionary<char, char>(s.Length);

            for (var i = 0; i < s.Length; i++)
            {
                var c = s[i];

                if (replaceDictionary.ContainsKey(c))
                {
                    if (replaceDictionary[c] != t[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (replaceDictionary.ContainsValue(t[i]))
                    {
                        return false;
                    }

                    replaceDictionary.Add(c, t[i]);
                }
            }

            return true;
        }
    }
}
