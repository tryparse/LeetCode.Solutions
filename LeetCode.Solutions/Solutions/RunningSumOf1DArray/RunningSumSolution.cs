using System;

namespace LeetCode.Solutions.RunningSumOf1DArray
{
    /// <summary>
    /// https://leetcode.com/problems/running-sum-of-1d-array/
    /// </summary>
    public class RunningSumSolution
    {
        public int[] RunningSum(int[] nums)
        {
            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var result = new int[nums.Length];

            result[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }
    }
}
