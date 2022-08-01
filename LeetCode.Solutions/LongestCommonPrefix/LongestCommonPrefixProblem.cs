using System.Linq;

namespace LeetCode.Solutions.LongestCommonPrefix
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// Write a function to find the longest common prefix string amongst an array of strings.
    /// If there is no common prefix, return an empty string "".
    /// </summary>
    public class LongestCommonPrefixProblem
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return string.Empty;
            }

            if (strs.Length == 1)
            {
                return strs[0];
            }

            if (strs.Length == 2)
            {
                if (strs[0] == strs[1])
                {
                    return strs[0];
                }
            }

            var shortest = strs
                .OrderBy(s => s.Length)
                .First();

            var commonPrefix = string.Empty;

            for (var i = 1; i <= shortest.Length; i++)
            {
                var newPrefix = shortest.Substring(0, i);

                foreach (var s in strs)
                {
                    if (!s.StartsWith(newPrefix))
                    {
                        return commonPrefix;
                    }
                }

                commonPrefix = newPrefix;
            }

            return commonPrefix;
        }
    }
}
