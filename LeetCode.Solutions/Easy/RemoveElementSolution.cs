using System;
using System.Linq;

namespace LeetCode.Solutions.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            var replace = -1;
            var replaceCount = 0;

            for (var i = 0; i < nums.Length - replaceCount; i++)
            {
                if (val == nums[i])
                {
                    nums[i] = replace;
                    replaceCount++;

                    for (var j = i; j < nums.Length - 1; j++)
                    {
                        nums[j] = nums[j + 1];
                        nums[j + 1] = replace;
                    }

                    i--;
                }
            }

            return nums.Count(x => x != replace);
        }
    }
}
