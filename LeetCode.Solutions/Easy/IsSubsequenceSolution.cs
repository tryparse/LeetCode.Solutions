namespace LeetCode.Solutions.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/is-subsequence/
    /// </summary>
    public class IsSubsequenceSolution
    {
        /*
        Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
        A subsequence of a string is a new string that is formed from the original string by
        deleting some (can be none) of the characters without disturbing the relative positions of the
        remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

        Example 1:

        Input: s = "abc", t = "ahbgdc"
        Output: true
        Example 2:

        Input: s = "axc", t = "ahbgdc"
        Output: false

        Constraints:

        0 <= s.length <= 100
        0 <= t.length <= 104
        s and t consist only of lowercase English letters.

        Follow up: Suppose there are lots of incoming s, say s1, s2, ..., sk 
        where k >= 109, and you want to check one by one to see if t has its subsequence.
        In this scenario, how would you change your code?
        */
        public bool IsSubsequence(string s, string t)
        {
            if (s == t)
            {
                return true;
            }

            if (s.Length > t.Length)
            {
                return false;
            }

            var previousIndex = 0;

            for (var i = 0; i < s.Length; i++)
            {
                var index = t.IndexOf(s[i], previousIndex);

                if (index == -1)
                {
                    return false;
                }

                previousIndex = index + 1;

                if (previousIndex > t.Length)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
