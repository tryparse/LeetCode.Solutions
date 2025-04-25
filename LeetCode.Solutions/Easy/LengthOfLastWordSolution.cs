using System;

namespace LeetCode.Solutions.Easy
{
    public class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            var words = s
                .TrimEnd()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return words[^1].Length;
        }
    }
}
