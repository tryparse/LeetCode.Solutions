using System;

namespace LeetCode.Solutions.RunningSumOf1DArray
{
    public class RunningSumSolution
    {
        public int[] RunningSum(int[] nums)
        {
            // 1,2,3,4

            if (nums.Length == 0)
            {
                return Array.Empty<int>();
            }

            var result = new int[nums.Length];

            result[0] = nums[0];

            for (var i = 1; i < nums.Length; i++)
            {
                result[i] = result[i-1] + nums[i];
            }

            return result;
        }
    }
}
