using System;

namespace LeetCode.Solutions.Solutions.Easy
{
    public class MergeStringsAlternatelySolution
    {
        public string MergeAlternately(string word1, string word2)
        {
            var lenght = Math.Max(word1.Length, word2.Length);
            var result = string.Empty;

            for (var i = 0; i < lenght; i++)
            {
                if (word1.Length < i)
                {
                    result += word1[i];
                }

                if (word2.Length < i)
                {
                    result += word2[i];
                }
            }

            return result;
        }
    }
}
