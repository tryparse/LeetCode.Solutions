using System;
using System.Linq;

namespace LeetCode.Solutions.Solutions.Easy.LengthOfLastWord
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
