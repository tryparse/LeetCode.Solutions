using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.MostCommonWord
{
    /// <summary>
    /// https://leetcode.com/contest/weekly-contest-80/problems/most-common-word/
    /// </summary>
    public class MostCommonWordProblem
    {
        private readonly string[] _punctuations = new string[] { "!", "?", "'", ",", ";", "." };

        public string MostCommonWord(string paragraph, string[] banned)
        {
            var cleanedInput = paragraph;

            foreach (var p in _punctuations)
            {
                cleanedInput = cleanedInput.Replace(p, " ");
            }

            cleanedInput = cleanedInput
                .ToLowerInvariant();

            var words = cleanedInput
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var dictionary = new Dictionary<string, int>();

            foreach (var s in words)
            {
                if (!banned.Contains(s))
                {
                    if (dictionary.ContainsKey(s))
                    {
                        dictionary[s]++;
                    }
                    else
                    {
                        dictionary[s] = 1;
                    }
                }
            }

            return dictionary
                .OrderBy(x => x.Value)
                .LastOrDefault()
                .Key;
        }
    }
}
